using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }

        public Persona(int id, string apellido, string nombre, DateTime fechaNac, string ciudad)
        {
            Id = id;
            Apellido = apellido;
            Nombre = nombre;
            FechaNacimiento = fechaNac;
            Ciudad = ciudad;
        }
    }
}
