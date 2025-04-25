using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlumnos
{
    public enum Categoria
    {
        titular,
        suplente,
        interino
    }
    public class Profesor : Persona
    {
        protected string materia;
        protected string titulo;
        protected Categoria tipo;

        protected string Materia { get { return materia; } set { materia = value; } }
        protected string Titulo { get { return titulo; } set { titulo = value; } }
        public string Tipo
        {
            get
            {
                switch (tipo)
                {
                    case Categoria.titular:
                        return "Titular";
                    case Categoria.suplente:
                        return "Suplente";
                    case Categoria.interino:
                        return "Interino";
                    default:
                        return "error";
                }
            }
        }
    }
}
