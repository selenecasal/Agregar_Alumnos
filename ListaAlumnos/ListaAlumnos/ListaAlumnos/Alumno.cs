using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumnos
{
    public class Alumno:Persona
    {
        protected int anio;
        protected int curso;

        protected int  Anio { get { return anio; } set { anio = value; } }
        protected int Curso { get { return curso;  } set { anio = value;  } }
    }
}
