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

using Capa_Negocio;
using CapaEntidad;
using Capa_Negocio;
using FontAwesome.Sharp;

namespace SISTEMA_VENTA
{
    public partial class Inicio : Form
    {
        public static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario = null)

        {
            if(objusuario == null) usuarioActual = new Usuario() { NombreCompleto = "ADMIN PREDEFINIDO", IdUsuario = 1};
            else
                usuarioActual = objusuario;

            InitializeComponent();
            usuarioActual = objusuario; 
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            foreach (IconMenuItem iconMenu in Menu.Items) {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);

                if (encontrado == false) {
                    iconMenu.Visible = false;
                }
            }
            lbusuario.Text = usuarioActual.NombreCompleto;
        }

        private void Abrirformulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor= Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null) {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.MidnightBlue;
            Contenedor.Controls.Add(formulario);
            formulario.Show();

        }


        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            Abrirformulario((IconMenuItem)sender,new FrmUsuarios());
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuMantenedor, new FrmCategoria());
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuMantenedor, new FrmProducto());
        }

        private void Submenuregistrarventa_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuVentas, new FrmVentas(usuarioActual));

        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuVentas, new frmDetalleVenta());

        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuCompras, new FrmCompras(usuarioActual));

        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            Abrirformulario(menuCompras, new frmDetalleCompra());

        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            Abrirformulario((IconMenuItem)sender, new frmClientes());

        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            Abrirformulario((IconMenuItem)sender, new frmProveedores());

        }

        private void menuReportes_Click(object sender, EventArgs e)
        {
            Abrirformulario((IconMenuItem)sender, new frmReportes());
        }
    }
}
