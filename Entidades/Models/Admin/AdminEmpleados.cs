using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Admin
{
    public static class AdminEmpleados
    {
        /// <summary>
        /// Filtra una lista de autores por ciudad
        /// </summary>
        /// <param name="autores">Una lista List<Autor></param>
        /// <param name="ciudad">Un string que representa una ciudad</param>
        /// <returns>Devuelve ua lista de tipo List<Autor> filtrada por ciudad</Autor></returns>
        public static List<Autor> listarPorCiudad(List<Autor> autores, string ciudad)
        {
            return autores.FindAll(
                delegate (Autor autor)
                {
                    return autor.Ciudad == ciudad;
                });
        }
    }
}
