using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    internal class Asignatura
    {
        public int Clave { get; }
        public string Nombre { get; }
        public int Creditos { get; }

        public Asignatura(int clave, string nombre, int creditos)
        {
            Clave = clave;
            Nombre = nombre;
            Creditos = creditos;
        }
    }
}
