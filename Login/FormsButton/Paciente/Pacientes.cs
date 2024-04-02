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
using Presentacion.FormsButton.Paciente.FormHijos.FormEstadoSalud;
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
            dtgvPacientes.DataSource = cnPaciente.mostrarPacientes();
        }

        public void Actualizardtgv()
        {
            MostrarPacientes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //METODO PARA ABRIR FORMULARIO HIJO
        private void AbrirFormulario<MiForm>(Pacientes paciente) where MiForm : Form
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = Activator.CreateInstance(typeof(MiForm)) as Form;
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;

                if(formulario is CrudPaciente crudPacienteForm)
                {
                    crudPacienteForm.pacienteForm = paciente;
                }

                formulario.ShowDialog();
                formulario.BringToFront();

            }
            else formulario.BringToFront();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CrudPaciente>(this);
        }

        private void dtgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0 && dtgvPacientes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow row = dtgvPacientes.Rows[e.RowIndex];

                MessageBox.Show("Se ha presionado el boton en la fila " + e.RowIndex.ToString());
            }
        }
    }
}
