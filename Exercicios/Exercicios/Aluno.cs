using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Aluno
    {
        public string Nome;
        public double PNota;
        public double SNota;
        public double TNota;
        public double NotaFinal()
        {
            return PNota + SNota + TNota;
        }
        

    }
}
