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
using Presentacion.FormsButton.Usuario.FormHijos;

namespace Presentacion.FormsButton.Usuario
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();

            
        }
        private void Usuario_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void AbrirFormulario<MiForm>(Usuario usuario) where MiForm : Form
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = Activator.CreateInstance(typeof(MiForm)) as Form;
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;

                if (formulario is CrudUsuario crudUsuarioForm)
                {
                    crudUsuarioForm.usuarioForm = usuario;
                }

                formulario.ShowDialog();
                formulario.BringToFront();
            }
            else formulario.BringToFront();
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CrudUsuario>(this);

        }

        //CRUD A USUARIOS.

        CnUsuario cnUsuario = new CnUsuario();
        public void mostrarUsuarios()
        {
            dtgvUsuarios.DataSource = cnUsuario.mostrarUsuarios();

        }
        public void Actualizardtgv()
        {
            mostrarUsuarios();
        }

        private void AbrirFormularioEditar<MiForm>(Usuario usuario) where MiForm : Form
        {
            if (dtgvUsuarios.SelectedRows.Count > 0)
            {
                string idUsuario = dtgvUsuarios.CurrentRow.Cells["ID"].Value.ToString();

                // Obtener el formulario CrudUsuario si ya está abierto
                CrudUsuario crudUsuarioForm = Application.OpenForms.OfType<CrudUsuario>().FirstOrDefault();

                if (crudUsuarioForm == null)
                {
                    crudUsuarioForm = new CrudUsuario(usuario);
                    crudUsuarioForm.TopLevel = true;
                    crudUsuarioForm.FormBorderStyle = FormBorderStyle.None;
                    crudUsuarioForm.StartPosition = FormStartPosition.CenterScreen;
                    crudUsuarioForm.operacion = "Editar";
                }

                // Cargar valores del usuario seleccionado en el formulario CrudUsuario
                crudUsuarioForm.CargarValores(
                    dtgvUsuarios.CurrentRow.Cells["Nombre"].Value.ToString(),
                    dtgvUsuarios.CurrentRow.Cells["Apellido"].Value.ToString(),
                    dtgvUsuarios.CurrentRow.Cells["Email"].Value.ToString(),
                    dtgvUsuarios.CurrentRow.Cells["Usuario"].Value.ToString(),
                    dtgvUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString(),
                    dtgvUsuarios.CurrentRow.Cells["Rol"].Value.ToString(),
                    idUsuario
                );

                crudUsuarioForm.ShowDialog();
                crudUsuarioForm.BringToFront();
            }
            else
            {
                MessageBox.Show("SELECCIONE LA FILA A EDITAR.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormularioEditar<CrudUsuario>(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dtgvUsuarios.SelectedRows.Count > 0)
            {
                cnUsuario.EliminarUsuario(dtgvUsuarios.CurrentRow.Cells[0].Value.ToString());
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
