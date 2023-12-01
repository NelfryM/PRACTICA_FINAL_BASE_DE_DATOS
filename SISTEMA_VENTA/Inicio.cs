using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;

namespace SISTEMA_VENTA
{
    public partial class Inicio : Form
    {
        public static Usuario usuarioActual;
        public Inicio(Usuario objusuario)
        {
            InitializeComponent();
            usuarioActual = objusuario; 
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lbusuario.Text = usuarioActual.NombreCompleto;
        }
    }
}
