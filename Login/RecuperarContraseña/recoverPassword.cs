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
            var result = user.getBackPassword(txtEmail.Text, txtContraseña.Text);
            lblResult.Text = result;


        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "EMAIL O USUARIO:";
            this.Close();
        }

        #region Efecto PlaceHolder
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA:")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = false;
            }

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA:";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL:";
                txtEmail.ForeColor = Color.LightGray;
            }

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL:")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.White;
            }

        }
        #endregion
    }
}
