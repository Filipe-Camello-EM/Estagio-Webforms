using Xunit;
using Domain;
using System;

namespace EM.Domain.Testes
{
    public class AlunoTestes
    {
        [Fact]
        public void TesteEquals()
        {
            Aluno aluno1 = new();
            aluno1.Matricula = 1;
            aluno1.Nascimento = new DateTime(1998,04,02);
            aluno1.Nome = "Filipe";
            aluno1.Sexo = EnumeradorSexo.Masculino;
            aluno1.CPF = "55555555555";

            Aluno aluno2 = new();
            aluno2.Matricula = 1;
            aluno2.Nascimento = new DateTime(1998,04,02);
            aluno2.Nome = "Filipe";
            aluno2.Sexo = EnumeradorSexo.Masculino;
            aluno2.CPF = "55555555555";

            aluno1.Equals(aluno2);

            Assert.Equal(aluno1.Matricula, aluno2.Matricula);
            Assert.Equal(aluno1.Nome, aluno2.Nome);
            Assert.Equal(aluno1.CPF, aluno2.CPF);
            Assert.Equal(aluno1.Nascimento, aluno2.Nascimento);
            Assert.Equal(aluno1.Sexo, aluno2.Sexo);
        }

        [Fact]
        public void TesteEqualsNull()
        {
            Aluno aluno1 = new();

            Aluno aluno2 = new();

            aluno1.Equals(aluno2);

            Assert.Equal(aluno1.Matricula, aluno2.Matricula);
            Assert.Equal(aluno1.Nome, aluno2.Nome);
            Assert.Equal(aluno1.CPF, aluno2.CPF);
            Assert.Equal(aluno1.Nascimento, aluno2.Nascimento);
            Assert.Equal(aluno1.Sexo, aluno2.Sexo);
        }

        [Fact]
        public void TesteHashCode()
        {
            Aluno aluno = new();
            aluno.Matricula = 1;

            Assert.Equal(1, aluno.GetHashCode());
        }

        [Fact]
        public void TesteToString()
        {
            Aluno aluno1 = new();
            aluno1.Matricula = 1;
            aluno1.Nascimento = new DateTime(1998,4,2);
            aluno1.Nome = "Filipe";
            aluno1.Sexo = EnumeradorSexo.Masculino;
            aluno1.CPF = "55555555555";
            Assert.Equal("Matricula: " + 1 + "\nNome: " + "Filipe" + "\nCPF: " + "555.555.555-55" + "\nNascimento: " + "2" + "-" + "4" + "-" + "1998" + "\nSexo: " + "Masculino",
                aluno1.ToString());

        }
    }
}