using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Aluno : IEntidade
    {
        [Required(ErrorMessage = "Erro: A Matrícula não pode ser nula")]
        [Range(1, 999999999, ErrorMessage = "Erro: A matrícula deve ser um número de até 9 dígitos, e não pode ser zero")]
        public int? Matricula { get; set; } = 0;


        [StringLength(100, MinimumLength = 1, ErrorMessage = "Erro: O nome deve ter entre 1 a 100 caracteres")]
        [Required(ErrorMessage = "Erro: O nome não pode ser nulo")]
        public string Nome { get; set; } = string.Empty;

        [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF deve conter exatamente 11 dígitos")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "O CPF deve conter apenas dígitos numéricos")]
        public string? CPF { get; set; } = string.Empty;


        [DataType(DataType.Date, ErrorMessage = "Formato de data inválido")]
        [Range(typeof(DateTime), "1/1/1900", "31/12/2020", ErrorMessage = "Não é possível cadastrar alunos nascidos antes de 1900 e a partir de 2021")]
        public DateTime? Nascimento { get; set; }

        public EnumeradorSexo Sexo { get; set; } = EnumeradorSexo.Masculino;

        public override string ToString()
        {
            return $"Matricula: {Matricula}\nNome: {Nome} " +
                $"{(string.IsNullOrEmpty(CPF) ? string.Empty : $"\nCPF: {new String(CPF.ToCharArray(), 0, 3)}.{new String(CPF.ToCharArray(), 3, 3)}.{new String(CPF.ToCharArray(), 6, 3)}-{new String(CPF.ToCharArray(), 9, 2)}")}" +
                $"\nNascimento: {Nascimento.Value.Day}-{Nascimento.Value.Month}-{Nascimento.Value.Year}\nSexo: {Sexo}";
        }

        public override bool Equals(Object aluno)
        {
            if (aluno is Aluno aluno2)
            {
                if (base.Equals(aluno))
                {
                    return true;
                }

                if (this.CPF == aluno2.CPF && this.Nome == aluno2.Nome && this.Nascimento == aluno2.Nascimento && this.Matricula == aluno2.Matricula && this.Sexo == aluno2.Sexo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return Matricula ?? 0;
        }
    }
}
