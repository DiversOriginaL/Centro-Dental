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
        private CnPaciente cnpaciente;
        public Pacientes()
        {
            InitializeComponent();
            cnpaciente = new CnPaciente();
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

        private void MostrarPacientes()
        {
            // Obtener la lista de pacientes desde la capa de negocio
            List<Common.Entidades.Paciente> listaPacientes = cnpaciente.ObtenerPacientes();

            // Asignar la lista de pacientes al DataSource del DataGridView
            dtgvPacientes.AutoGenerateColumns = true;
            dtgvPacientes.DataSource = listaPacientes;
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
