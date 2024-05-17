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

        CrudPaciente crudPacienteForm;
        public EstadoSalud(CrudPaciente crudPacienteForm) : this()
        {
            this.crudPacienteForm = crudPacienteForm;
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

        private void txtEnfermedad_Enter(object sender, EventArgs e)
        {
            if(txtEnfermedad.Text == "DESCRIPCION:")
            {
                txtEnfermedad.Text = "";
                txtEnfermedad.ForeColor = Color.Black;
                Font fuente = new Font("Tahoma", 12, FontStyle.Regular);
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
            if (txtMedicamento.Text == "DESCRIPCION:")
            {
                txtMedicamento.Text = "";
                txtMedicamento.ForeColor = Color.Black;
                Font fuente = new Font("Tahoma", 12, FontStyle.Regular);
                txtMedicamento.Font = fuente;
            }
        }
        private void txtAlergia_Leave(object sender, EventArgs e)
        {
            if (txtMedicamento.Text == "")
            {
                txtMedicamento.Text = "DESCRIPCION:";
                txtMedicamento.ForeColor = Color.Silver;
                Font fuente = new Font("Tahoma", 16, FontStyle.Bold);
                txtMedicamento.Font = fuente;
            }
        }

        private void txtMedicamento_Enter(object sender, EventArgs e)
        {
            if (txtAlergia.Text == "DESCRIPCION:")
            {
                txtAlergia.Text = "";
                txtAlergia.ForeColor = Color.Black;
                Font fuente = new Font("Tahoma", 12, FontStyle.Regular);
                txtAlergia.Font = fuente;
            }
        }
        private void txtMedicamento_Leave(object sender, EventArgs e)
        {
            if (txtAlergia.Text == "")
            {
                txtAlergia.Text = "DESCRIPCION:";
                txtAlergia.ForeColor = Color.Silver;
                Font fuente = new Font("Tahoma", 16, FontStyle.Bold);
                txtAlergia.Font = fuente;
            }
        }

        private void txtEmbarazo_Enter(object sender, EventArgs e)
        {
            if (txtEmbarazo.Text == "DESCRIPCION:")
            {
                txtEmbarazo.Text = "";
                txtEmbarazo.ForeColor = Color.Black;

                Font fuente = new Font("Tahoma", 12, FontStyle.Regular);
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
            txtMedicamento.Text = "DESCRIPCION:";
            txtMedicamento.ForeColor = Color.Silver;

            txtEnfermedad.Text = "DESCRIPCION:";
            txtEnfermedad.ForeColor = Color.Silver;

            txtAlergia.Text = "DESCRIPCION:";
            txtAlergia.ForeColor = Color.Silver;

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

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarValoresSalud(string enfermedad, string medicamento, string alergia, string embarazo)
        {
            txtEnfermedad.Text = enfermedad;
            txtMedicamento.Text = medicamento;
            txtAlergia.Text = alergia;
            txtEmbarazo.Text = embarazo;

            txtEnfermedad.ForeColor = Color.Black;
            txtMedicamento.ForeColor = Color.Black;
            txtAlergia.ForeColor = Color.Black;
            txtEmbarazo.ForeColor = Color.Black;
        }

        public void GetActualizaciones()
        {
            // Obtener los datos de salud del formulario EstadoSalud
            string enfermedad = txtEnfermedad.Text;
            string medicamento = txtMedicamento.Text;
            string alergia = txtAlergia.Text;
            string embarazo = txtEmbarazo.Text;


            // Verificar si el formulario CrudPaciente está abierto y pasarel los datos de salud
            if (crudPacienteForm != null)
            {
                crudPacienteForm.GetDatosSalud(enfermedad, medicamento, alergia, embarazo);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GetActualizaciones();
            this.Close();
        }
        
    }
}
