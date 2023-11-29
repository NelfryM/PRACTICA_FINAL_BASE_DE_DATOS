using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using CapaEntidad;

namespace Capa_Negocio
{
    public class CN_Usuario
    {

        private CD_Usuario objed_usuario = new CD_Usuario();

        public List<Usuario>Listar()
        {
            return objed_usuario.Listar();
        }
    }
}
