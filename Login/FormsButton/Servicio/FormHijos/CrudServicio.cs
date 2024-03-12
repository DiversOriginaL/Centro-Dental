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
        #endregion

        #region EfectoPlaceHolder
        private void cbPaciente_Enter(object sender, EventArgs e)
        {
            if(cbPaciente.Text == "PACIENTE:")
            {
                cbPaciente.Text = "";
                cbPaciente.ForeColor = Color.Black;

                Font fuente = new Font("Tahoma", 14, FontStyle.Bold);
                cbPaciente.Font = fuente;
            }
        }

        private void cbPaciente_Leave(object sender, EventArgs e)
        {
            if( cbPaciente.Text == "")
            {
                cbPaciente.Text = "PACIENTE:";
                cbPaciente.ForeColor = Color.Silver;
               
                Font fuente = new Font("Tahoma", 14, FontStyle.Bold);
                cbPaciente.Font = fuente;
            }
        }

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

        private void txtSubTotal_Enter(object sender, EventArgs e)
        {
            if (txtSubTotal.Text == "SUBTOTAL:")
            {
                txtSubTotal.Text = "";
                txtSubTotal.ForeColor = Color.Black;
            }
        }

        private void txtSubTotal_Leave(object sender, EventArgs e)
        {
            if (txtSubTotal.Text == "")
            {
                txtSubTotal.Text = "SUBTOTAL:";
                txtSubTotal.ForeColor = Color.Silver;
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

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            if (txtTotal.Text == "TOTAL:")
            {
                txtTotal.Text = "";
                txtTotal.ForeColor = Color.Black;
            }

        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (txtTotal.Text == "")
            {
                txtTotal.Text = "TOTAL:";
                txtTotal.ForeColor = Color.Silver;
            }

        }

        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbPaciente.Text = "";
            cbServicio.Text = "";
            txtCosto.Text = "";
            txtCantidad.Text = "";
            txtSubTotal.Text = "";
            txtDescuento.Text = "";
            txtTotal.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbPaciente.Text = "PACIENTE:";
            cbServicio.Text = "SERVICIO:";
            txtCosto.Text = "PRECIO:";
            txtCantidad.Text = "CANTIDAD:";
            txtSubTotal.Text = "SUBTOTAL:";
            txtDescuento.Text = "DESCUENTO:";
            txtTotal.Text = "TOTAL:";

            this.Close();
        }
    }
}
