using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Presentacion.FormsButton.Paciente.FormHijos;
using Common.Cache;
using Domain.Domain;

namespace Presentacion.FormsButton.Paciente
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }
        private void Pacientes_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
            Permisos();
        }
        private void Permisos()
        {
            //DELEGANDO PERMISOS
            if (UserLoginCache.RolId() == Positions.DoctoraEncagada ||
               UserLoginCache.RolId() == Positions.Recepcionista ||
               UserLoginCache.RolId() == Positions.Empleado)
            {
                btnEliminar.Enabled = false;
            }

        }
        CnPaciente cnPaciente = new CnPaciente();
        private void MostrarPacientes()
        {
            dtgvPacientes.DataSource = cnPaciente.ObtenerPacientes();
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
