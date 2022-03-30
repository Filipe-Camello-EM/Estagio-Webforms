namespace WindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botaoPesquisa = new System.Windows.Forms.Button();
            this.matriculaBox = new System.Windows.Forms.TextBox();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.cpfBox = new System.Windows.Forms.TextBox();
            this.sexoBox = new System.Windows.Forms.ComboBox();
            this.matriculaLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.nascimentoLabel = new System.Windows.Forms.Label();
            this.cpfLabel = new System.Windows.Forms.Label();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.nascimentoBox = new System.Windows.Forms.MaskedTextBox();
            this.excluirBotao = new System.Windows.Forms.Button();
            this.editarBotao = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.pesquisaBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuClickDireito = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.MenuClickDireito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(165, 230);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(587, 137);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting_1);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDoubleClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // botaoPesquisa
            // 
            this.botaoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPesquisa.Location = new System.Drawing.Point(642, 193);
            this.botaoPesquisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botaoPesquisa.Name = "botaoPesquisa";
            this.botaoPesquisa.Size = new System.Drawing.Size(111, 30);
            this.botaoPesquisa.TabIndex = 8;
            this.botaoPesquisa.Text = "Pesquisar";
            this.botaoPesquisa.UseVisualStyleBackColor = true;
            this.botaoPesquisa.Click += new System.EventHandler(this.BotaoPesquisa_Click);
            // 
            // matriculaBox
            // 
            this.matriculaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.matriculaBox.Location = new System.Drawing.Point(13, 53);
            this.matriculaBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.matriculaBox.MaxLength = 9;
            this.matriculaBox.Name = "matriculaBox";
            this.matriculaBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.matriculaBox.Size = new System.Drawing.Size(123, 26);
            this.matriculaBox.TabIndex = 0;
            this.matriculaBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatriculaBox_KeyPress);
            // 
            // nomeBox
            // 
            this.nomeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeBox.Location = new System.Drawing.Point(156, 53);
            this.nomeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nomeBox.MaxLength = 100;
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(584, 26);
            this.nomeBox.TabIndex = 1;
            this.nomeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NomeBox_KeyPress);
            // 
            // cpfBox
            // 
            this.cpfBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpfBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpfBox.Location = new System.Drawing.Point(296, 119);
            this.cpfBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cpfBox.MaxLength = 11;
            this.cpfBox.Name = "cpfBox";
            this.cpfBox.Size = new System.Drawing.Size(190, 26);
            this.cpfBox.TabIndex = 4;
            this.cpfBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatriculaBox_KeyPress);
            // 
            // sexoBox
            // 
            this.sexoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sexoBox.FormattingEnabled = true;
            this.sexoBox.Location = new System.Drawing.Point(13, 117);
            this.sexoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sexoBox.Name = "sexoBox";
            this.sexoBox.Size = new System.Drawing.Size(119, 28);
            this.sexoBox.TabIndex = 2;
            // 
            // matriculaLabel
            // 
            this.matriculaLabel.AutoSize = true;
            this.matriculaLabel.Location = new System.Drawing.Point(9, 35);
            this.matriculaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.matriculaLabel.Name = "matriculaLabel";
            this.matriculaLabel.Size = new System.Drawing.Size(57, 15);
            this.matriculaLabel.TabIndex = 7;
            this.matriculaLabel.Text = "Matrícula";
            // 
            // nomeLabel
            // 
            this.nomeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(153, 35);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(40, 15);
            this.nomeLabel.TabIndex = 8;
            this.nomeLabel.Text = "Nome";
            // 
            // sexoLabel
            // 
            this.sexoLabel.AutoSize = true;
            this.sexoLabel.Location = new System.Drawing.Point(9, 98);
            this.sexoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(32, 15);
            this.sexoLabel.TabIndex = 9;
            this.sexoLabel.Text = "Sexo";
            // 
            // nascimentoLabel
            // 
            this.nascimentoLabel.AutoSize = true;
            this.nascimentoLabel.Location = new System.Drawing.Point(153, 102);
            this.nascimentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nascimentoLabel.Name = "nascimentoLabel";
            this.nascimentoLabel.Size = new System.Drawing.Size(71, 15);
            this.nascimentoLabel.TabIndex = 10;
            this.nascimentoLabel.Text = "Nascimento";
            // 
            // cpfLabel
            // 
            this.cpfLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpfLabel.AutoSize = true;
            this.cpfLabel.Location = new System.Drawing.Point(293, 102);
            this.cpfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpfLabel.Name = "cpfLabel";
            this.cpfLabel.Size = new System.Drawing.Size(28, 15);
            this.cpfLabel.TabIndex = 11;
            this.cpfLabel.Text = "CPF";
            // 
            // adicionarButton
            // 
            this.adicionarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adicionarButton.Location = new System.Drawing.Point(630, 119);
            this.adicionarButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(111, 30);
            this.adicionarButton.TabIndex = 6;
            this.adicionarButton.Text = "Adicionar";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.AdicionarButton_Click);
            // 
            // nascimentoBox
            // 
            this.nascimentoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nascimentoBox.Location = new System.Drawing.Point(156, 119);
            this.nascimentoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nascimentoBox.Mask = "00/00/0000";
            this.nascimentoBox.Name = "nascimentoBox";
            this.nascimentoBox.Size = new System.Drawing.Size(116, 26);
            this.nascimentoBox.TabIndex = 3;
            this.nascimentoBox.ValidatingType = typeof(System.DateTime);
            // 
            // excluirBotao
            // 
            this.excluirBotao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirBotao.Location = new System.Drawing.Point(642, 374);
            this.excluirBotao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.excluirBotao.Name = "excluirBotao";
            this.excluirBotao.Size = new System.Drawing.Size(111, 28);
            this.excluirBotao.TabIndex = 10;
            this.excluirBotao.Text = "Excluir";
            this.excluirBotao.UseVisualStyleBackColor = true;
            this.excluirBotao.Click += new System.EventHandler(this.ExcluirBotao_Click);
            // 
            // editarBotao
            // 
            this.editarBotao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editarBotao.Location = new System.Drawing.Point(519, 374);
            this.editarBotao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.editarBotao.Name = "editarBotao";
            this.editarBotao.Size = new System.Drawing.Size(115, 27);
            this.editarBotao.TabIndex = 9;
            this.editarBotao.Text = "Editar";
            this.editarBotao.UseVisualStyleBackColor = true;
            this.editarBotao.Click += new System.EventHandler(this.EditarBotao_Click);
            // 
            // limparButton
            // 
            this.limparButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.limparButton.Location = new System.Drawing.Point(507, 119);
            this.limparButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(115, 30);
            this.limparButton.TabIndex = 5;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.LimparButton_Click);
            // 
            // pesquisaBox
            // 
            this.pesquisaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pesquisaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pesquisaBox.Location = new System.Drawing.Point(24, 193);
            this.pesquisaBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pesquisaBox.Name = "pesquisaBox";
            this.pesquisaBox.Size = new System.Drawing.Size(610, 26);
            this.pesquisaBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.limparButton);
            this.groupBox1.Controls.Add(this.nascimentoBox);
            this.groupBox1.Controls.Add(this.adicionarButton);
            this.groupBox1.Controls.Add(this.cpfLabel);
            this.groupBox1.Controls.Add(this.nascimentoLabel);
            this.groupBox1.Controls.Add(this.sexoLabel);
            this.groupBox1.Controls.Add(this.nomeLabel);
            this.groupBox1.Controls.Add(this.matriculaLabel);
            this.groupBox1.Controls.Add(this.sexoBox);
            this.groupBox1.Controls.Add(this.cpfBox);
            this.groupBox1.Controls.Add(this.nomeBox);
            this.groupBox1.Controls.Add(this.matriculaBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(757, 180);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo aluno/Editando aluno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(7, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Os campos marcados com (*) são obrigatórios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(38, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(221, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(191, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "*";
            // 
            // MenuClickDireito
            // 
            this.MenuClickDireito.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.MenuClickDireito.Name = "contextMenuStrip1";
            this.MenuClickDireito.Size = new System.Drawing.Size(110, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(20, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 137);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(784, 410);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pesquisaBox);
            this.Controls.Add(this.editarBotao);
            this.Controls.Add(this.excluirBotao);
            this.Controls.Add(this.botaoPesquisa);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(800, 449);
            this.Name = "Form1";
            this.Text = "Cadastro de Alunos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MenuClickDireito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button botaoPesquisa;
        internal System.Windows.Forms.TextBox matriculaBox;
        internal System.Windows.Forms.TextBox nomeBox;
        internal System.Windows.Forms.TextBox cpfBox;
        internal System.Windows.Forms.ComboBox sexoBox;
        internal System.Windows.Forms.Label matriculaLabel;
        internal System.Windows.Forms.Label nomeLabel;
        internal System.Windows.Forms.Label sexoLabel;
        internal System.Windows.Forms.Label nascimentoLabel;
        internal System.Windows.Forms.Label cpfLabel;
        internal System.Windows.Forms.Button adicionarButton;
        internal System.Windows.Forms.MaskedTextBox nascimentoBox;
        internal System.Windows.Forms.Button excluirBotao;
        internal System.Windows.Forms.Button editarBotao;
        internal System.Windows.Forms.Button limparButton;
        internal System.Windows.Forms.TextBox pesquisaBox;
        internal System.Windows.Forms.GroupBox groupBox1;
        private ContextMenuStrip MenuClickDireito;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public BindingSource bindingSource1;
    }
}

