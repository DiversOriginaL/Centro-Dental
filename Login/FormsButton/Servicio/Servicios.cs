using Presentacion.FormsButton.Servicios.FormHijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain.Domain;
using Presentacion.FormsButton.Servicio.VerDetalles;

namespace Presentacion.FormsButton.Servicio
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }
        private void Servicios_Load(object sender, EventArgs e)
        {
            mostrarFacturas();
            Permisos();
        }

        CnFactura cnFactura = new CnFactura();
        private void mostrarFacturas()
        {
            dtgvServicios.DataSource = cnFactura.mostrarFacturas();
        }

        public void actualizardtgv()
        {
            mostrarFacturas();
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
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //METODO PARA ABRIR FORMULARIO HIJO.
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
            AbrirFormulario<CrudServicio>();
        }

        private void dtgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvServicios.SelectedRows.Count > 0)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dtgvServicios.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    id = dtgvServicios.SelectedRows[0].Cells["FacturaID"].Value.ToString();
                    verDetalles<VerDetalle>(this);
                }
            }

        }
        
        string id;
        private void verDetalles<MiForm>(Servicios servicio) where MiForm : Form
        {
            VerDetalle formulario;
            formulario = Application.OpenForms.OfType<VerDetalle>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new VerDetalle();
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;
                formulario.getFacturaID(id);

                formulario.ShowDialog();
                formulario.BringToFront();

            }
            else formulario.BringToFront();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormularioEditar<CrudServicio>(this);
        }
        string pacienteID;
        string paciente;
        private void AbrirFormularioEditar<MiForm>(Servicios service) where MiForm : Form
        {
            if (dtgvServicios.SelectedRows.Count > 0)
            {
                // Obtener el formulario CrudUsuario si ya está abierto

                id = dtgvServicios.CurrentRow.Cells["FacturaID"].Value.ToString();
                pacienteID = dtgvServicios.CurrentRow.Cells["PacienteID"].Value.ToString();
                paciente = dtgvServicios.CurrentRow.Cells["Paciente"].Value.ToString();

                VerDetalle valor = new VerDetalle();

                CrudServicio crudServicioForm = Application.OpenForms.OfType<CrudServicio>().FirstOrDefault();

                if (crudServicioForm == null)
                {
                    crudServicioForm = new CrudServicio(service);
                    crudServicioForm.TopLevel = true;
                    crudServicioForm.FormBorderStyle = FormBorderStyle.None;
                    crudServicioForm.StartPosition = FormStartPosition.CenterScreen;
                    crudServicioForm.operacion = "Editar";
                }
                
                valor.cargarDetallesDtgv(crudServicioForm, id, pacienteID, paciente);

                crudServicioForm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A EDITAR.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarFacturaConDetalles();
        }

        private void EliminarFacturaConDetalles()
        {
            if (dtgvServicios.SelectedRows.Count > 0)
            {
                string FacturaID = dtgvServicios.SelectedRows[0].Cells["FacturaID"].Value.ToString();
                cnFactura.EliminarFacturaConDetalles(FacturaID);
                actualizardtgv();
            }
        }
    }
}
