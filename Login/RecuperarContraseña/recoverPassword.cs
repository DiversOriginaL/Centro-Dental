using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Domain.Domain;

namespace Presentacion.RecuperarContraseña
{
    public partial class recoverPassword : Form
    {
        public recoverPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.getBackPassword(txtEmailUsuario.Text, txtContraseña.Text);
            lblResult.Text = result;
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            txtEmailUsuario.Text = "EMAIL O USUARIO:";
            this.Close();
        }

        private void txtEmailUsuario_Enter(object sender, EventArgs e)
        {
            if(txtEmailUsuario.Text == "EMAIL O USUARIO:")
            {
                txtEmailUsuario.Text = "";
                txtEmailUsuario.ForeColor = Color.White;
            }
        }

        private void txtEmailUsuario_Leave(object sender, EventArgs e)
        {
            if (txtEmailUsuario.Text == "")
            {
                txtEmailUsuario.Text = "EMAIL O USUARIO:";
                txtEmailUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA:")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
            }

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA:";
                txtContraseña.ForeColor = Color.LightGray;
            }

        }
    }
}
