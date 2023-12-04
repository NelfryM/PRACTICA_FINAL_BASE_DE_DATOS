using Capa_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Rol
    {
        private CD_Rol objed_permiso = new CD_Rol();

        public List<Rol> Listar()
        {
            return objed_permiso.Listar();
        }
    }
}
