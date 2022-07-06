using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Faculty
{
    internal class ControlEscolar
    {
        private List<Alumno> alumnos;
        private List<Asignatura> asignaturas;
        private List<Calificacion> calificaciones;

        public ControlEscolar()
        {
            alumnos = EasyFile<Alumno>.LoadDataFromFile("alumnos.txt",
                tokens => new Alumno(Convert.ToInt32(tokens[0]),
                                      tokens[1], tokens[2]));
            asignaturas = EasyFile<Asignatura>.LoadDataFromFile("asignaturas.txt",
                tokens => new Asignatura(Convert.ToInt32(tokens[0]),
                                        tokens[1],
                                        Convert.ToInt32(tokens[2])));
            calificaciones = EasyFile<Calificacion>.LoadDataFromFile("calificaciones.txt",
                tokens => new Calificacion(Convert.ToInt32(tokens[0]),
                                      Convert.ToInt32(tokens[1]),
                                      Convert.ToInt32(tokens[2])));
        }

        public List<Alumno> GetAlumnosPorNombre()
        {
            alumnos.Sort((a, b) => a.NombreCompleto.CompareTo(b.NombreCompleto));
            return alumnos;
        }

        public List<Alumno> GetAlumnos() => new List<Alumno>(alumnos);

        public List<CalificacionConInfo> GetCalificacionesPorAlumno()
        {
            List<CalificacionConInfo> cci = new List<CalificacionConInfo>();

            calificaciones.ForEach(a =>
                cci.Add(new CalificacionConInfo(
                           alumnos.Find(p => p.Matricula == a.Matricula),
                           asignaturas.Find(d => d.Clave == a.Clave),
                           a.Nota)));

            cci.Sort((a, b) => a.Alumno.Apellido.CompareTo(b.Alumno.Apellido));

            return cci;
        }

        public List<Asignatura> GetAsignaturas() => new List<Asignatura>(asignaturas);
    }
}
