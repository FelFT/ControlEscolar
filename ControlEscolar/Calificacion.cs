using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    internal class Calificacion
    {
        public int Matricula { get; }
        public int Clave { get; }
        public int Nota { get; }

        public Calificacion(int matricula, int clave, int nota)
        {
            Matricula = matricula;
            Clave = clave;
            Nota = nota;
        }
    }
}
