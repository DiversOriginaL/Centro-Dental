using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.FormsButton.Usuario.FormHijos
{
    public partial class CrudUsuario : Form
    {
        public CrudUsuario()
        {
            InitializeComponent();
        }

        #region Efecto PlaceHolder
        private void txtNombres_Enter(object sender, EventArgs e)
        {
            if(txtNombres.Text == "NOMBRES:")
            {
                txtNombres.Text = "";
                txtNombres.ForeColor = Color.Black;
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if(txtNombres.Text == "")
            {
                txtNombres.Text = "NOMBRES:";
                txtNombres.ForeColor = Color.Silver;
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "APELLIDOS:")
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.Black;

            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "APELLIDOS:";
                txtApellidos.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL:")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL:";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO:")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO:";
                txtUsuario.ForeColor = Color.Silver;

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA:")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA:";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombres.Text = "NOMBRES:";
            txtApellidos.Text = "APELLIDOS:";
            txtEmail.Text = "EMAIL:";
            txtUsuario.Text = "USUARIO:";
            txtContraseña.Text = "CONTRASEÑA:";
            this.Close();
        }

        private void CrudUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
