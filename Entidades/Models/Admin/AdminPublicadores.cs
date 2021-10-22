using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Admin
{
    public static class AdminPublicadores
    {
        public static List<Publicador> publicadores = new List<Publicador>()
            {
                new Publicador(0, "Fernandez", "Pedro", new DateTime(1995,10,5),"La Plata"),
                new Publicador(1, "Hernandez", "Florencia", new DateTime(1996,09,20),"Los Hornos")
            };

        public static List<Publicador> Listar()
        {
            return publicadores;
        }

        public static void Insertar(Publicador p)
        {
            publicadores.Add(p);
        }

        public static void Eliminar(int id)
        {
            Publicador p = publicadores.Find(publicador => publicador.Id == id);
            publicadores.Remove(p);
        }
    }
}
