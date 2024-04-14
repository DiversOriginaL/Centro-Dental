using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.FormsButton.Servicio.FormHijos.CargarPaciente;

namespace Presentacion.FormsButton.Servicios.FormHijos
{
    public partial class CrudServicio : Form
    {
        public CrudServicio()
        {
            InitializeComponent();
        }

        #region MoverFormulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void CrudServicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }

        private void dtgvCrudServicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }

        private void pnDown_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        #endregion

        #region EfectoPlaceHolder

        private void cbServicio_Enter(object sender, EventArgs e)
        {
            if (cbServicio.Text == "SERVICIO:")
            {
                cbServicio.Text = "";
                cbServicio.ForeColor = Color.Black;
            }
        }

        private void cbServicio_Leave(object sender, EventArgs e)
        {
            if (cbServicio.Text == "")
            {
                cbServicio.Text = "SERVICIO:";
                cbServicio.ForeColor = Color.Silver;

            }
        }

        private void txtCosto_Enter(object sender, EventArgs e)
        {
            if(txtCosto.Text == "PRECIO:")
            {
                txtCosto.Text = "";
                txtCosto.ForeColor = Color.Black;
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (txtCosto.Text == "")
            {
                txtCosto.Text = "PRECIO:";
                txtCosto.ForeColor = Color.Silver;
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if(txtCantidad.Text == "CANTIDAD:")
            {
                txtCantidad.Text = "";
                txtCantidad.ForeColor = Color.Black;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "CANTIDAD:";
                txtCantidad.ForeColor = Color.Silver;
            }
        }

        private void txtDescuento_Enter(object sender, EventArgs e)
        {
            if (txtDescuento.Text == "DESCUENTO:")
            {
                txtDescuento.Text = "";
                txtDescuento.ForeColor = Color.Black;
            }

        }

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if (txtDescuento.Text == "")
            {
                txtDescuento.Text = "DESCUENTO:";
                txtDescuento.ForeColor = Color.Silver;
            }

        }

        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbServicio.Text = "";
            txtCosto.Text = "";
            txtCantidad.Text = "";
            txtDescuento.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbServicio.Text = "SERVICIO:";
            txtCosto.Text = "PRECIO:";
            txtCantidad.Text = "CANTIDAD:";
            txtDescuento.Text = "DESCUENTO:";

            this.Close();
        }

        string id;
        string pnombre;
        string papellido;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string pnombre = this.pnombre;
            string papellido = this.papellido;
            string servicio = cbServicio.Text.Trim();
            string precio = txtCosto.Text.Trim();
            string cantidad = txtCantidad.Text.Trim();
            string descuento = txtDescuento.Text.Trim();

            dtgvCrudServicio.Rows.Add(new object[] {id, pnombre + " " + papellido, servicio, precio, cantidad, "", "", descuento, "Eliminar"});
            
            cbServicio.Text = "SERVICIO:";
            txtCosto.Text = "PRECIO:";
            txtCantidad.Text = "CANTIDAD:";
            txtDescuento.Text = "DESCUENTO:";

            dtgvCrudServicio.ClearSelection();

        }
        private void btnCargarPaciente_Click(object sender, EventArgs e)
        {
            AbrirCargarPaciente<CargaPaciente>(this);
        }

        private void AbrirCargarPaciente<MiForm>(CrudServicio crudservicio) where MiForm : Form
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if(formulario == null)
            {
                formulario = Activator.CreateInstance(typeof(MiForm)) as Form;
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;

                if(formulario is CargaPaciente crudservicioform)
                {
                    crudservicioform.crudServicioForm = crudservicio;
                }

                formulario.ShowDialog();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        public void getid(string id, string pnombre, string papellido)
        {
            this.id = id;
            this.pnombre = pnombre;
            this.papellido = papellido;
        }

    }
}
