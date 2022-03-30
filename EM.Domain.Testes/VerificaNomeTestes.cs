using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Domain;

namespace EM.Domain.Testes
{
    public class VerificaNomeTestes
    {
        Aluno aluno1 = new();
        Aluno aluno2 = new();
        [Fact]
        public void AlunoNaoPodeSerNulo()
        {
            aluno1.Nome = "";
            Assert.False(Verificacoes.VerificaNomeVazio (aluno1));
        }

        [Fact]
        public void AlunoNaoPodeConterMaisDeCemCaracteres()
        {
            aluno1.Nome = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Assert.False(Verificacoes.VerificaNome(aluno1));
        }

        [Fact]
        public void AlunoContemApenasLetrasEEspacosVazios()
        {
            aluno1.Nome = "Filipe Camello";
            aluno2.Nome = "Ana Maria Braga";

            Assert.True (Verificacoes.VerificaNome (aluno1) && Verificacoes.VerificaNome(aluno2));

            aluno1.Nome = "Filipe";
            aluno2.Nome = "Ana";

            Assert.True(Verificacoes.VerificaNome(aluno1) && Verificacoes.VerificaNome(aluno2));

            aluno1.Nome = "Filipe1";
            aluno2.Nome = "Ana-";

            Assert.False(Verificacoes.VerificaNome(aluno1) && Verificacoes.VerificaNome(aluno2));

        }


    }
}
