using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Negocio;
using CapaEntidad;


namespace SISTEMA_VENTA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario ousuario= new CN_Usuario().Listar().Where(u => u.IdUsuario == txtusuario.Text = "";.Text && u.Clave = txtclave.Text).FirstOrDefault();

            Inicio form = new Inicio();
            form.Show();
            this.Hide();

            form.FormClosing += Frm_closing;
        }

        private void Frm_closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtclave.Text = "";
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
