using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Domain;
using Presentacion.FormsButton.Paciente.FormHijos.FormEstadoSalud;
using System.Runtime.InteropServices;

namespace Presentacion.FormsButton.Paciente.FormHijos
{
    public partial class CrudPaciente : Form
    {
        public CrudPaciente()
        {
            InitializeComponent();
        }

        #region MoverFormulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void CrudPaciente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        #endregion


        #region EfectoPlaceHolder y Configuracion de controles
        private void txtPnombre_Enter(object sender, EventArgs e)
        {
            if(txtPnombre.Text == "PRIMER NOMBRE:")
            {
                txtPnombre.Text = "";
                txtPnombre.ForeColor = Color.Black;
            }
        }

        private void txtPnombre_Leave(object sender, EventArgs e)
        {
            if (txtPnombre.Text == "")
            {
                txtPnombre.Text = "PRIMER NOMBRE:";
                txtPnombre.ForeColor = Color.Silver;
            }
        }

        private void txtSnombre_Enter(object sender, EventArgs e)
        {
            if (txtSnombre.Text == "SEGUNDO NOMBRE:")
            {
                txtSnombre.Text = "";
                txtSnombre.ForeColor = Color.Black;
            }

        }

        private void txtSnombre_Leave(object sender, EventArgs e)
        {
            if (txtSnombre.Text == "")
            {
                txtSnombre.Text = "SEGUNDO NOMBRE:";
                txtSnombre.ForeColor = Color.Silver;
            }
        }

        private void txtPapellido_Enter(object sender, EventArgs e)
        {
            if (txtPapellido.Text == "PRIMER APELLIDO:")
            {
                txtPapellido.Text = "";
                txtPapellido.ForeColor = Color.Black;
            }

        }

        private void txtPapellido_Leave(object sender, EventArgs e)
        {
            if (txtPapellido.Text == "")
            {
                txtPapellido.Text = "PRIMER APELLIDO:";
                txtPapellido.ForeColor = Color.Silver;
            }
        }

        private void txtSapellido_Enter(object sender, EventArgs e)
        {
            if (txtSapellido.Text == "SEGUNDO APELLIDO:")
            {
                txtSapellido.Text = "";
                txtSapellido.ForeColor = Color.Black;
            }

        }

        private void txtSapellido_Leave(object sender, EventArgs e)
        {
            if (txtSapellido.Text == "")
            {
                txtSapellido.Text = "SEGUNDO APELLIDO:";
                txtSapellido.ForeColor = Color.Silver;
            }

        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text == "EDAD:")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.Black;
            }

        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtEdad.Text = "EDAD:";
                txtEdad.ForeColor = Color.Silver;
            }

        }
        private void cbSexo_Leave(object sender, EventArgs e)
        {
            if (cbSexo.SelectedIndex >= 0)
                cbSexo.ForeColor = Color.Black;

        }

        private void txtCelular_Enter(object sender, EventArgs e)
        {
            if (txtCelular.Text == "CELULAR:")
            {
                txtCelular.Text = "";
                txtCelular.ForeColor = Color.Black;
            }

        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                txtCelular.Text = "CELULAR:";
                txtCelular.ForeColor = Color.Silver;
            }

        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "TELEFONO:")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }

        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "TELEFONO:";
                txtTelefono.ForeColor = Color.Silver;
            }
        }

        private void txtCiudad_Enter(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "CIUDAD:")
            {
                txtCiudad.Text = "";
                txtCiudad.ForeColor = Color.Black;
            }
        }

        private void txtCiudad_Leave(object sender, EventArgs e)
        {
            if (txtCiudad.Text == "")
            {
                txtCiudad.Text = "CIUDAD:";
                txtCiudad.ForeColor = Color.Silver;
            }
        }

        private void txtSector_Enter(object sender, EventArgs e)
        {
            if (txtSector.Text == "SECTOR:")
            {
                txtSector.Text = "";
                txtSector.ForeColor = Color.Black;
            }
        }

        private void txtSector_Leave(object sender, EventArgs e)
        {
            if (txtSector.Text == "")
            {
                txtSector.Text = "SECTOR:";
                txtSector.ForeColor = Color.Silver;
            }
        }

        private void txtCalle_Enter(object sender, EventArgs e)
        {
            if (txtCalle.Text == "CALLE:")
            {
                txtCalle.Text = "";
                txtCalle.ForeColor = Color.Black;
            }
        }

        private void txtCalle_Leave(object sender, EventArgs e)
        {
            if(txtCalle.Text == "")
            {
                txtCalle.Text = "CALLE:";
                txtCalle.ForeColor = Color.Silver;

            }
        }

        private void txtNumCasa_Enter(object sender, EventArgs e)
        {
            if (txtNumCasa.Text == "NUMERO DE CASA:")
            {
                txtNumCasa.Text = "";
                txtNumCasa.ForeColor = Color.Black;
            }
        }

        private void txtNumCasa_Leave(object sender, EventArgs e)
        {
            if (txtNumCasa.Text == "")
            {
                txtNumCasa.Text = "NUMERO DE CASA:";
                txtNumCasa.ForeColor = Color.Silver;
            }
        }
        //Cerra, maximizar y minimizar.
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            txtPnombre.Text = "PRIMER NOMBRE:";
            txtSnombre.Text = "SEGUNDO NOMBRE:";
            txtPapellido.Text = "PRIMER APELLIDO";
            txtSapellido.Text = "SEGUNDO APELLIDO:";
            txtEdad.Text = "EDAD:";
            cbSexo.Text = "SEXO:";
            txtCelular.Text = "CELULAR:";
            txtTelefono.Text = "TELEFONO:";
            txtCiudad.Text = "CIUDAD:";
            txtSector.Text = "SECTOR:";
            txtCalle.Text = "CALLE:";
            txtNumCasa.Text = "NUMERO DE CASA:";
            this.Close();

        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else WindowState = FormWindowState.Maximized;

        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        //ABRIR FORMULARIO HIJO
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if(formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterParent;

                formulario.ShowDialog();
                formulario.BringToFront();
            }
            else formulario.BringToFront();

        }
        private void btnEstadoSalud_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EstadoSalud>();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPnombre.Text = "PRIMER NOMBRE:";
            txtSnombre.Text = "SEGUNDO NOMBRE:";
            txtPapellido.Text = "PRIMER APELLIDO";
            txtSapellido.Text = "SEGUNDO APELLIDO:";
            txtEdad.Text = "EDAD:";
            cbSexo.Text = "SEXO:";
            txtCelular.Text = "CELULAR:";
            txtTelefono.Text = "TELEFONO:";
            txtCiudad.Text = "CIUDAD:";
            txtSector.Text = "SECTOR:";
            txtNumCasa.Text = "NUMERO DE CASA:";
            this.Close();

        }

        CnPaciente cnPaciente = new CnPaciente();
        EstadoSalud estadosalud = new EstadoSalud();

        public string operacion = "Insertar";
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string pnombre = txtPnombre.Text;
            string snombre = txtSnombre.Text;
            string papellido = txtPapellido.Text;
            string sapellido = txtSapellido.Text;
            string edad = txtEdad.Text;
            object sexo = cbSexo.SelectedItem;
            string celular = txtCelular.Text;
            string telefono = txtTelefono.Text;
            string ciudad = txtCiudad.Text;
            string sector = txtSector.Text;
            string calle = txtCalle.Text;
            string numcasa = txtNumCasa.Text;

            try
            {
                if (operacion == "Insertar")
                {
                    cnPaciente.insertarPaciente
                    (
                        pnombre, snombre, papellido, sapellido, edad, sexo,
                        celular, telefono, ciudad, sector, calle, numcasa,
                        estadosalud.enfermedad, estadosalud.medicamento, estadosalud.alergia, estadosalud.embarazo
                     );
                    MessageBox.Show("PACIENTE INSERTADO CORRECTAMENTE.");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

    }
}
