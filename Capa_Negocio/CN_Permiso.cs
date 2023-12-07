using Capa_Datos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Permiso
    {
        private CD_Permiso objed_permiso = new CD_Permiso();

        public List<Permiso> Listar(int idUsuario)
        {
            return objed_permiso.Listar(idUsuario);
        }
    }
}
