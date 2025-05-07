using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumnos
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected DateTime fechanac;
        protected int telefono;
        protected string email;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public DateTime Fechanac { get { return fechanac; } set { fechanac = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }


    }
}
