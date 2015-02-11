using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Alumnos
{
    /// <summary>
    /// Clase que reprsenta a los alumnos de una clase
    /// </summary>
    class Alumnos
    {
        /// <summary>
        /// Declaramos una lista sin tamaño fijo
        /// </summary>
        private ArrayList listaAlumnos = new ArrayList();   
        /// <summary>
        /// Creamos la lista de los alumnos y llenamos el array con ella
        /// </summary>
        private string ListaAlumnos
        {
            get
            {
                string lista = "";

                foreach(string alumno in listaAlumnos)
                    lista=lista+alumno+"\n";

                    return lista;
            }
        }
        /// <summary>
        /// Agregamos un alumno a la lista
        /// </summary>
        /// <param name="alum">Nombre y nota del alumno perteneciente al aula.</param>
        public void AgregarAlumno(Alumno alum)
        {
            listaAlumnos.Add(alum);
        }
        /// <summary>
        /// Calcula la nota media de todos los alumnos y la devuelve como valor de tipo double
        /// </summary>
        public double MediaNotas(double sumNotas)
        {
            double res;
            {
                res=sumNotas/listaAlumnos.Count;
                return res;
            }
        }

    }
}
