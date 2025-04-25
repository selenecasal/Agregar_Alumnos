using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Humano
{
    class Profesor : Persona
    {
     string materia;
     string titulo;
     public enum Categoria{
        titular,
        suplente,
        provisional
        }
    }
}
