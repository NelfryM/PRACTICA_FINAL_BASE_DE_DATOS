using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SISTEMA_VENTA;
using SISTEMA_VENTA.Utilidades;
using CapaEntidad;
using Capa_Negocio;

namespace SISTEMA_VENTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cboEstado.Items.Add(new OpcionCombo() { Valor =1, Texto= "Activo"});
            cboEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo" });
            cboEstado.DisplayMember = "Texto";
            cboEstado.ValueMember = "Valor";
            cboEstado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol) {
                cboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion});
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar") {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText});
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<Usuario> listaUsuario = new CN_Usuario().Listar();
            foreach (Usuario item in listaUsuario)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdUsuario, item.Documento,item.NombreCompleto, item.Correo,item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ?1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
            });
            }
            cboRol.DisplayMember = "Texto";
            cboRol.ValueMember = "Valor";
            cboRol.SelectedIndex = 0;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dgvdata.Rows.Add(new object[] {"",txtid.Text, txtDocumento.Text,txtNombrecompleto.Text, txtCorreo.Text,txtclave.Text,
            ((OpcionCombo)cboRol.SelectedItem).Valor.ToString(),
            ((OpcionCombo)cboRol.SelectedItem).Texto.ToString(),
            ((OpcionCombo)cboEstado.SelectedItem).Valor.ToString(),
            ((OpcionCombo)cboEstado.SelectedItem).Texto.ToString()
            });

            Limpiar();
        }

        private void Limpiar()
        {
            txtid.Text = "0";
            txtDocumento.Text = "";
            txtNombrecompleto.Text = "";
            txtCorreo.Text = "";
            txtclave.Text = "";
            txtconfirmclave.Text = "";
            cboRol.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 )
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.Chcekmark.Width;
                var h = Properties.Resources.Chcekmark.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) /2;
                var y =  e.CellBounds.Top + (e.CellBounds.Height - h) /2;

                e.Graphics.DrawImage(Properties.Resources.Chcekmark, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar") {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtDocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txtconfirmclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();

                }

            }

        }
    }
}
