using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faculty
{
    internal class CalificacionConInfo
    {
        public Alumno Alumno { get; }
        public Asignatura Asignatura { get; }
        public int Calificacion { get; }

        public CalificacionConInfo(Alumno alumno, Asignatura asignatura, int calificacion)
        {
            Alumno = alumno;
            Asignatura = asignatura;
            Calificacion = calificacion;
        }
    }
}
