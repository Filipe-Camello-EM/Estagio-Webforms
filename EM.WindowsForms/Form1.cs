using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Repository;

namespace WindowsForms
{

    public partial class Form1 : Form
    {
        private Aluno ConstroiAlunoPelosTextBox()
        {
            Aluno aluno = new();

            int.TryParse(matriculaBox.Text, out int matriculaInt);
            DateTime nascimento;
            if (DateTime.TryParseExact(nascimentoBox.Text, "dd/MM/yyyy", null, DateTimeStyles.NoCurrentDateDefault, out nascimento))
            {
                aluno.Nascimento = nascimento;
            }

            aluno.Matricula = matriculaInt;

            aluno.Nome = Regex.Replace (nomeBox.Text, @"\s+", " ");
            if (aluno.Nome.StartsWith(" "))
            {
                aluno.Nome = aluno.Nome.Remove(0, 1);
            }
            aluno.CPF = cpfBox.Text;
            Enum.TryParse((string)sexoBox.SelectedItem, out EnumeradorSexo sexo);
            aluno.Sexo = sexo;
            char [] matriculaArray = matriculaBox.Text.ToCharArray();
            foreach (char element in matriculaArray)
            {
                if (!Char.IsDigit(element))
                {
                    aluno.Matricula = -1;
                }
            }
            return aluno;
        }
        private void LimpaCampos()
        {
            nomeBox.Text = string.Empty;
            cpfBox.Text = string.Empty;
            matriculaBox.Text = string.Empty;
            nascimentoBox.Text = string.Empty;
            sexoBox.Text = string.Empty;
        }

        private void PreencheCamposDoForms(Aluno aluno)
        {
            nomeBox.Text = aluno.Nome;
            cpfBox.Text = aluno.CPF;
            matriculaBox.Text = aluno.Matricula.ToString();
            nascimentoBox.Text = aluno.Nascimento.ToString();
            sexoBox.Text = aluno.Sexo.ToString();
        }
        
        private void AtualizaDataGrid()
        {
            RepositorioAluno repositorioAluno = new();

            bindingSource1.DataSource = repositorioAluno.GetByContendoNoNome(pesquisaBox.Text).ToSortableBindingList();

            if (int.TryParse(pesquisaBox.Text, out int matricula))
            {                
                if (repositorioAluno.GetByMatricula(matricula) is null)
                {
                        MessageBox.Show("Nenhum aluno encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bindingSource1.DataSource = repositorioAluno.GetByMatricula(matricula);
            }
            dataGridView1.DataSource = bindingSource1;
        }

        string controladoraBotoes = "ModoAdicionar";
        private void TrocaBotoes(Button adicionar, Button limpar)
        {
            if (controladoraBotoes == "ModoModificar")
            {
                adicionar.Text = "Modificar";
                limpar.Text = "Cancelar";
            }
            else
            {
                adicionar.Text = "Adicionar";
                limpar.Text = "Limpar";
            }

        }

        public Form1()
        {
            RepositorioAluno repositorioAluno = new RepositorioAluno();
            InitializeComponent();
            sexoBox.Items.Add("Masculino");
            sexoBox.Items.Add("Feminino");
            sexoBox.SelectedIndex = 0;
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            Aluno aluno = ConstroiAlunoPelosTextBox();
            RepositorioAluno repositorioAluno = new ();
            List <string> verificacoes = Verificacoes.VerificaTodosAtributos(aluno, repositorioAluno.GetAll());

            if (controladoraBotoes == "ModoModificar")
            {
                verificacoes.Remove("Matrícula já cadastrada");
                if (verificacoes.First() == "verificado")
                {
                    repositorioAluno.Update(aluno);
                    PreencheCamposDoForms(aluno);
                    controladoraBotoes = "ModoAdicionar";
                    matriculaBox.ReadOnly = false;
                    LimpaCampos();
                    AtualizaDataGrid();
                }
                else                
                {
                    verificacoes.Remove("verificado");
                    string erros = verificacoes.Aggregate((erro1, erro2) => erro1 + "\n" + erro2);
                    MessageBox.Show(erros, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
                    
            }

            else if (controladoraBotoes == "ModoAdicionar")
            {
                if (verificacoes.First() == "verificado") 
                {
                    repositorioAluno.Add(aluno);
                    LimpaCampos();
                    AtualizaDataGrid();
                }
                else
                {
                    verificacoes.Remove("verificado");
                    string erros = verificacoes.Aggregate ((erro1, erro2) => erro1 + "\n" + erro2);
                    MessageBox.Show(erros, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }

            TrocaBotoes(adicionarButton, limparButton);
            
        }

        private void ExcluirBotao_Click(object sender, EventArgs e)
        {
            Aluno aluno = (Aluno) bindingSource1.Current;
            RepositorioAluno repositorioAluno = new ();

            string mensagem = "Você irá excluir o seguinte aluno do sistema:\n" + aluno + "\nTem certeza disso?";
            string titulo = "Confirmação";
            if (MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (controladoraBotoes == "ModoModificar")
                {
                    controladoraBotoes = "ModoAdicionar";
                    LimpaCampos();
                    matriculaBox.ReadOnly = false;
                    TrocaBotoes(adicionarButton, limparButton);
                }

                repositorioAluno.Remove(aluno);
                AtualizaDataGrid();
            }

        }

        private void EditarBotao_Click(object sender, EventArgs e)
        {
            matriculaBox.ReadOnly = true;
            controladoraBotoes = "ModoModificar";
            TrocaBotoes(adicionarButton, limparButton);
            Aluno aluno = (Aluno) bindingSource1.Current;
            PreencheCamposDoForms(aluno);
        }

        private void LimparButton_Click(object sender, EventArgs e)
        {
            if (limparButton.Text == "Cancelar")
            {
                controladoraBotoes = "ModoAdicionar";
                matriculaBox.ReadOnly = false;
                TrocaBotoes(adicionarButton, limparButton);
                LimpaCampos();
            }
            else
            {
                LimpaCampos();
            }
        }

        private void MatriculaBox_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            if (!char.IsControl(KeyPressEvent.KeyChar) && !char.IsDigit(KeyPressEvent.KeyChar))
            {
                KeyPressEvent.Handled = true;
            }
        }

        private void CpfBox_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            if (!char.IsControl(KeyPressEvent.KeyChar) && !char.IsDigit(KeyPressEvent.KeyChar))
            {
                KeyPressEvent.Handled = true;
            }
        }

        private void BotaoPesquisa_Click(object sender, EventArgs e)
        {
            AtualizaDataGrid();         
        }

        private void NomeBox_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
        {
            if (!char.IsControl(KeyPressEvent.KeyChar) && !char.IsLetter(KeyPressEvent.KeyChar) && !char.IsWhiteSpace(KeyPressEvent.KeyChar))
            {
                KeyPressEvent.Handled = true;
            }
        }

        private void DataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)

        {
            if (e.ColumnIndex == 2 && e.Value.ToString() != string.Empty)
            {
                char[] CPFDividido = e.Value.ToString().ToCharArray();                
                String CPF = new String(CPFDividido, 0, 3) + "." + new String(CPFDividido, 3, 3) + "." + new String(CPFDividido, 6, 3) + "-" + new String(CPFDividido, 9, 2);
                e.Value = CPF;
                e.FormattingApplied = true;
            }
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    ExcluirBotao_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView1.SelectedRows.Count > 0) 
                    {
                    EditarBotao_Click(sender, e);
                    e.SuppressKeyPress = true;
                    }
            }
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditarBotao_Click(sender, e);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarBotao_Click(sender, e);
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirBotao_Click(sender, e);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView1.HitTest(e.X, e.Y);
                if (dataGridView1.Rows.Count > 0 && hti.RowIndex >= 0)
                {
                    dataGridView1.Rows[hti.RowIndex].Selected = true;
                    MenuClickDireito.Show(MousePosition);
                }
            }
        }
    }
}
