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
        private void verSalud<MiForm>(Pacientes paciente) where MiForm : Form
        {
            AbrirEstadoSalud formulario;
            formulario = Application.OpenForms.OfType<AbrirEstadoSalud>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new AbrirEstadoSalud();
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.verEstadoSalud(
                    dtgvPacientes.CurrentRow.Cells["Enfermedad"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Medicamento"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Alergia"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Embarazo"].Value.ToString()
                    );

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
            if (dtgvPacientes.SelectedRows.Count > 0)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dtgvPacientes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    verSalud<AbrirEstadoSalud>(this);
                }
            }
        }

        private void AbrirFormularioEditar<MiForm>(Pacientes paciente) where MiForm : Form
        {
            if (dtgvPacientes.SelectedRows.Count > 0)
            {
                string idPaciente = dtgvPacientes.CurrentRow.Cells["ID"].Value.ToString();

                // Obtener el formulario CrudUsuario si ya está abierto
                CrudPaciente crudPacienteForm = Application.OpenForms.OfType<CrudPaciente>().FirstOrDefault();

                if (crudPacienteForm == null)
                {
                    crudPacienteForm = new CrudPaciente(paciente);
                    crudPacienteForm.TopLevel = true;
                    crudPacienteForm.FormBorderStyle = FormBorderStyle.None;
                    crudPacienteForm.StartPosition = FormStartPosition.CenterScreen;
                    crudPacienteForm.operacion = "Editar";
                }

                // Cargar valores del usuario seleccionado en el formulario CrudUsuario
                crudPacienteForm.CargarValores(
                    idPaciente,
                    dtgvPacientes.CurrentRow.Cells["PNombre"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["SNombre"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["PApellido"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["SApellido"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Edad"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Sexo"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Celular"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Telefono"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Provincia"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Sector"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Calle"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["NumCasa"].Value.ToString()

                );

                crudPacienteForm.EnviarDatosSalud(
                    dtgvPacientes.CurrentRow.Cells["Enfermedad"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Medicamento"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Alergia"].Value.ToString(),
                    dtgvPacientes.CurrentRow.Cells["Embarazo"].Value.ToString()
                    );

                crudPacienteForm.ShowDialog();
                crudPacienteForm.BringToFront();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A EDITAR.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormularioEditar<CrudPaciente>(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvPacientes.SelectedRows.Count > 0)
            {
                cnPaciente.eliminarPaciente(dtgvPacientes.CurrentRow.Cells["ID"].Value.ToString());
                MessageBox.Show("Se elimino correctamente.");
                Actualizardtgv();
            }
            else
            {
                MessageBox.Show("Primero debe de seleccionar una fila.");
            }
        }
    }
}
