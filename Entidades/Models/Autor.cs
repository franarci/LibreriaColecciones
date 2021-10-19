using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Autor : Persona
    {
        public string Nacionalidad { get; set; }
        public Autor(int id, string apellido, string nombre, DateTime fechaNac, string ciudad, string nacionalidad) : base(id, apellido, nombre, fechaNac, ciudad)
        {
            Nacionalidad = nacionalidad;
        }
    }
}
