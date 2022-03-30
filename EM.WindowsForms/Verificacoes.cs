using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Domain;

namespace WindowsForms
{
    public class Verificacoes : Form1
    {
        public static Boolean VerificaMatriculaIguais(IEntidade aluno, IEnumerable<IEntidade> entidades)
        {
            foreach (Aluno alunoNaLista in entidades)
            {
                if (aluno.Matricula == alunoNaLista.Matricula)
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean VerificaMatriculaVazia(IEntidade aluno)
        {
            return (aluno.Matricula == 0);
        }

        public static Boolean VerificaMatricula(IEntidade aluno)
        {
            return (aluno.Matricula < 0 || aluno.Matricula > 999999999);
        }

        public static Boolean VerificaCPFsIguais(IEntidade aluno, IEnumerable<IEntidade> entidades)
        {
            foreach (Aluno alunoNaLista in entidades)
            {
                if (aluno.Matricula == alunoNaLista.Matricula)
                {
                    ;
                }
                else if (aluno.CPF == alunoNaLista.CPF)
                {
                    return false;
                }
            }

            return true;

        }

        public static Boolean VerificaCPF(IEntidade aluno)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            if ((aluno.CPF.Length == 11) && new string(aluno.CPF[0], aluno.CPF.Length) == aluno.CPF)
            {
                return false;
            }

            if (aluno.CPF == string.Empty)
            {
                return true;
            }

            if (aluno.CPF.Length != 11)
            {
                return false;
            }

            foreach (char caractere in aluno.CPF.Trim())
            {
                if (char.IsDigit(caractere) == false)
                {
                    return false;
                }
            }
            tempCpf = aluno.CPF.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            }

            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma % 11;
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito += resto.ToString();
            return aluno.CPF.EndsWith(digito);
        }

        public static Boolean VerificaNomeVazio(IEntidade aluno)
        {
            return (aluno.Nome == string.Empty || aluno.Nome.Trim() == string.Empty);
        }

        public static Boolean VerificaNome(IEntidade aluno)
        {
            foreach (char caractere in aluno.Nome.ToCharArray())
            {
                if (!Char.IsLetter(caractere) && !Char.IsWhiteSpace(caractere) || (aluno.Nome.Length > 100))
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean VerificaNascimentoVazio (IEntidade aluno)
        {
            return (aluno.Nascimento == null);
        }

        public static Boolean VerificaNascimento(IEntidade aluno)
        {
            if (aluno.Nascimento != null) 
            {
                return !(aluno.Nascimento.Value.Month >= 1 && aluno.Nascimento.Value.Month <= 12
                   && aluno.Nascimento.Value.Day >= 1 && aluno.Nascimento.Value.Day <= DateTime.DaysInMonth(aluno.Nascimento.Value.Year, aluno.Nascimento.Value.Month));
            }
                return false;
        }

        public static Boolean VerificaIdade(IEntidade aluno)
        {
            if (aluno.Nascimento != null)
            {
                return !(aluno.Nascimento.Value.Year >= 1900 && aluno.Nascimento.Value.Year < 2020);
            }
            return false;
        }

        public static List <string> VerificaTodosAtributos(IEntidade aluno, IEnumerable<IEntidade> entidades)
        {
            List<string> verificacao = new();
            if (VerificaCPF(aluno) == false)
            {
                verificacao.Add("CPF inválido");
            }

            if (VerificaMatriculaIguais(aluno, entidades))
            {
                verificacao.Add("Matrícula já cadastrada");
            }

            if (!(VerificaCPFsIguais(aluno, entidades) || aluno.CPF == string.Empty))
            {
                verificacao.Add("CPF já cadastrado");
            }

            if (VerificaMatriculaVazia(aluno))
            {
                verificacao.Add("O campo \"Matrícula\" não pode ser vazio");
            }

            if (VerificaNomeVazio(aluno))
            {
                verificacao.Add("O campo \"Nome\" não pode ser vazio");
            }

            if (VerificaMatricula(aluno))
            {
                verificacao.Add("Matricula Invalida");
            }

            if (VerificaNome(aluno))
            {
                verificacao.Add("Nome inválido");
            }

            if (VerificaNascimentoVazio (aluno))
            {
                verificacao.Add("Data de nascimento vazia ou inválida");
            }

            if (VerificaNascimento(aluno))
            {
                verificacao.Add("Data de Nascimento inválida");
            }

            if (VerificaIdade(aluno))
            {
                verificacao.Add("Apenas alunos nascidos após 1900 e antes de 2020 são permitidos");
            }

            verificacao.Add("verificado");
            return verificacao;
        }
    }
}
