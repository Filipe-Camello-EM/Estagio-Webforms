using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Xunit;

namespace EM.Domain.Testes
{
    public class VerificaMatriculaTestes
    {
        Aluno aluno1 = new();
        [Fact]
        public void MatriculaAceitaApenasAteNoveDigitos()
        {
            aluno1.Matricula = 123;
            Assert.True(Verificacoes.VerificaMatricula(aluno1));
            aluno1.Matricula = 999999999;
            Assert.True(Verificacoes.VerificaMatricula(aluno1));
            aluno1.Matricula = 1000000000;
            Assert.False(Verificacoes.VerificaMatricula(aluno1));          
        }

        [Fact]
        public void MatriculaNaoPodeSerZeroOuNegativa()
        {
            aluno1.Matricula = 0;
            Assert.False (Verificacoes.VerificaMatriculaVazia (aluno1));
            aluno1.Matricula = -1;
            Assert.False(Verificacoes.VerificaMatricula(aluno1));
        }
    }
}
