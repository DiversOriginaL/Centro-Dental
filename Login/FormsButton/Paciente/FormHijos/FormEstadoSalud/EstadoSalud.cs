using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion.FormsButton.Paciente.FormHijos.FormEstadoSalud
{
    public partial class EstadoSalud : Form
    {
        public EstadoSalud()
        {
            InitializeComponent();
        }

        #region MoverFormulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void EstadoSalud_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        #endregion

        #region Efecto PlaceHolder y Configuracion de controles.
        private void rbSiEnfermedad_CheckedChanged(object sender, EventArgs e)
        {
            txtEnfermedad.Visible = true;
            txtEnfermedad.Enabled = true;
        }

        private void rbSiAlergia_CheckedChanged(object sender, EventArgs e)
        {
            txtAlergia.Visible = true;
            txtAlergia.Enabled = true;
        }

        private void rdSiMedicamento_CheckedChanged(object sender, EventArgs e)
        {
            txtMedicamento.Visible = true;
            txtMedicamento.Enabled = true;
        }

        private void rbSiEmbarazada_CheckedChanged(object sender, EventArgs e)
        {
            txtEmbarazo.Visible = true;
            txtEmbarazo.Enabled = true;
        }

        private void txtEnfermedad_Enter(object sender, EventArgs e)
        {
            if(txtEnfermedad.Text == "DESCRIPCION:")
            {
                txtEnfermedad.Text = "";
                txtEnfermedad.ForeColor = Color.Black;
                Font fuente = new Font("Tahoma", 12, FontStyle.Bold);
                txtEnfermedad.Font = fuente;
            }
        }

        private void txtEnfermedad_Leave(object sender, EventArgs e)
        {
            if(txtEnfermedad.Text == "")
            {
                txtEnfermedad.Text = "DESCRIPCION:";
                txtEnfermedad.ForeColor = Color.Silver;
                Font fuente = new Font("Tahoma", 16, FontStyle.Bold);
                txtEnfermedad.Font = fuente;
            }
        }

        private void txtAlergia_Enter(object sender, EventArgs e)
        {
            if (txtAlergia.Text == "DESCRIPCION:")
            {
                txtAlergia.Text = "";
                txtAlergia.ForeColor = Color.Black;
                Font fuente = new Font("Tahoma", 12, FontStyle.Bold);
                txtAlergia.Font = fuente;
            }
        }

        private void txtAlergia_Leave(object sender, EventArgs e)
        {
            if (txtAlergia.Text == "")
            {
                txtAlergia.Text = "DESCRIPCION:";
                txtAlergia.ForeColor = Color.Silver;
                Font fuente = new Font("Tahoma", 16, FontStyle.Bold);
                txtAlergia.Font = fuente;
            }
        }
        private void txtMedicamento_Enter(object sender, EventArgs e)
        {
            if (txtMedicamento.Text == "DESCRIPCION:")
            {
                txtMedicamento.Text = "";
                txtMedicamento.ForeColor = Color.Black;
                Font fuente = new Font("Tahoma", 12, FontStyle.Bold);
                txtMedicamento.Font = fuente;
            }
        }

        private void txtMedicamento_Leave(object sender, EventArgs e)
        {
            if (txtMedicamento.Text == "")
            {
                txtMedicamento.Text = "DESCRIPCION:";
                txtMedicamento.ForeColor = Color.Silver;
                Font fuente = new Font("Tahoma", 16, FontStyle.Bold);
                txtMedicamento.Font = fuente;
            }
        }

        private void txtEmbarazo_Enter(object sender, EventArgs e)
        {
            if (txtEmbarazo.Text == "DESCRIPCION:")
            {
                txtEmbarazo.Text = "";
                txtEmbarazo.ForeColor = Color.Black;

                Font fuente = new Font("Tahoma", 12, FontStyle.Bold);
                txtEmbarazo.Font = fuente;
            }
        }

        private void txtEmbarazo_Leave(object sender, EventArgs e)
        {
            if (txtEmbarazo.Text == "")
            {
                txtEmbarazo.Text = "DESCRIPCION:";
                txtEmbarazo.ForeColor = Color.Silver;
                Font fuente = new Font("Tahoma", 16, FontStyle.Bold);
                txtEmbarazo.Font = fuente;
            }
        }
        private void pnCerrar_Click(object sender, EventArgs e)
        {
            txtAlergia.Text = "DESCRIPCION:";
            txtAlergia.ForeColor = Color.Silver;

            txtEnfermedad.Text = "DESCRIPCION:";
            txtEnfermedad.ForeColor = Color.Silver;

            txtMedicamento.Text = "DESCRIPCION:";
            txtMedicamento.ForeColor = Color.Silver;

            txtEmbarazo.Text = "DESCRIPCION:";
            txtEmbarazo.ForeColor = Color.Silver;

            this.Close();

        }

        private void pnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;
        }

        private void pnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rbNoEnfermedad_CheckedChanged(object sender, EventArgs e)
        {
            txtEnfermedad.Visible = false;

        }

        private void rbNoAlergia_CheckedChanged(object sender, EventArgs e)
        {
            txtAlergia.Visible = false;
        }

        private void rdNoMedicamento_CheckedChanged(object sender, EventArgs e)
        {
            txtMedicamento.Visible = false;
        }

        private void rbNoEmbarazada_CheckedChanged(object sender, EventArgs e)
        {
            txtEmbarazo.Visible = false;
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAlergia.Text = "DESCRIPCION:";
            txtAlergia.ForeColor = Color.Silver;

            txtEnfermedad.Text = "DESCRIPCION:";
            txtEnfermedad.ForeColor = Color.Silver;

            txtMedicamento.Text = "DESCRIPCION:";
            txtMedicamento.ForeColor = Color.Silver;

            txtEmbarazo.Text = "DESCRIPCION:";
            txtEmbarazo.ForeColor = Color.Silver;

            this.Close();

        }

    }
}
