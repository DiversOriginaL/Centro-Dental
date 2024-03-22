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


        CnUsuario cnUsuario = new CnUsuario();
        public void mostrarUsuarios()
        {
            dtgvUsuarios.DataSource = cnUsuario.mostrarUsuarios();

        }
        public void Actualizardtgv()
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

    }
}
