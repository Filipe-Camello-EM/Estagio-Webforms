using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Domain;

namespace EM.Domain.Testes
{
    public class VerificaNascimentoTestes
    {
        Aluno aluno1 = new();
        [Fact]
        public void NascimentoDeveSerUmaDataValida()
        {

            aluno1.Nascimento = new DateTime(2024, 01, 01);
            Assert.False(Verificacoes.VerificaNascimento(aluno1));

            aluno1.Nascimento = new DateTime(1500, 04, 22);
            Assert.False(Verificacoes.VerificaNascimento(aluno1));

            aluno1.Nascimento = new DateTime(1997, 10, 10);
            Assert.True(Verificacoes.VerificaNascimento(aluno1));
        }
    }
}
