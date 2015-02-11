using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    /// <summary>
    /// Clase que representa a un alumno
    /// </summary>
    class Alumno
    {
        private string nombre;
        private int nota;

        /// <summary>
        /// Nombre del alumno.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Nota del alumno 
        /// </summary>
        public int Nota
        {
            get { return nota; }
            set 
            {
                if (value >= 0 && value<=10)
                    nota = value;
            }
        }

        /// <summary>
        /// Valor aprobado o suspendido, dependiendo de la nota
        /// </summary>
        public Boolean Aprobado
        {
            get
            {
                if (nota >= 5)
                    return true;
                else
                    return false;
            }
        }
    }
}
