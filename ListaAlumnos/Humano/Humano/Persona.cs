using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humano
{
    class Persona
    {
        abstract class Figura
        {
            string nombre;
            string apellido;
            DateTime fechaNamiento;
            string dni;
            string eMail;
            int telefono;
            string direccion;
        }
    }
}
