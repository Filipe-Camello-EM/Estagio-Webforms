using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Domain;

namespace EM.Domain.Testes
{
    public class VerificaCPFTestes
    {
        Aluno aluno1 = new();

        [Fact]
        public void CPFPodeSerVazio ()
        {
            aluno1.CPF = "";
            Assert.True(Verificacoes.VerificaCPF(aluno1));
        }

        [Fact]
        public void CPFNaoDeveConterMenosDeOnzeDígitos ()
        {
            aluno1.CPF = "123";
            Assert.False (Verificacoes.VerificaCPF (aluno1));
        }

        [Fact]
        public void CPFNaoDeveConterMaisDoQueOnzeDigitos ()
        {
            aluno1.CPF = "123456789101112";
            Assert.False(Verificacoes.VerificaCPF(aluno1));
        }
    }
}
