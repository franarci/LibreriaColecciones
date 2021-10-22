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
        /// Busca un empleado por id
        /// </summary>
        /// <param name="empleados">Una lista List<Empleado></param>
        /// <param name="id">Un int que representa un id</param>
        /// <returns>Devuelve un empleado, resultado de filtrar por id</returns>
        public static Empleado buscarPorId(List<Empleado> empleados, int id)
        {
            int index = 0;
            while (index < empleados.Count - 1)
            {
                if (empleados[index].Id == id)
                {
                    break;
                }
                else
                {
                    index++;
                }
            }

            return empleados[index].Id == id ? empleados[index] : null;
        }

        /// <summary>
        /// Elimina un empleado por id
        /// </summary>
        /// <param name="empleados">Una lista List<Empleado></param>
        /// <param name="id">Un id</param>
        public static void Eliminar(List<Empleado> empleados,int id)
        {

            Empleado e = buscarPorId(empleados, id);
            if(e != null)
            {
                empleados.Remove(e);
            }   
        }
    }
}
