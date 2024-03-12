using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.FormsButton.Paciente.FormHijos;

namespace Presentacion.FormsButton.Paciente
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODO PARA ABRIR FORMULARIO HIJO
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CrudPaciente>();
        }
    }
}
