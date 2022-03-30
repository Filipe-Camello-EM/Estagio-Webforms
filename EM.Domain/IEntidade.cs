using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IEntidade
    {

        int ? Matricula { get; set; }

        string Nome { get; set; }

        string ? CPF { get; set; }

        DateTime ? Nascimento { get; set; }

        EnumeradorSexo Sexo { get; set; }

        bool Equals(object objeto);

        int GetHashCode();

        string ToString();

    }
}
