using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Login.Domain.Domain;
using Presentacion.RecuperarContraseña;
using Presentacion.FormWelcome;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region Efecto PlaceHolder, Movilidad de Formulario y Configuracion de controles.
        //=======================================================DISEÑO==========================================

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd , int wmsg, IntPtr wParam, IntPtr lParam);


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO:")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
                pnLogo.BackColor = Color.WhiteSmoke;

                lblErrorMessage.Visible = false;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO:";
                txtUsuario.ForeColor = Color.LightGray;
                pnLogo.BackColor = Color.Silver;

            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA:")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = false;
                pnLogo.BackColor = Color.WhiteSmoke;

                lblErrorMessage.Visible = false;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA:";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
                pnLogo.BackColor = Color.Silver;

            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);

            if (txtUsuario.Text != "USUARIO:" && txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO:";
                txtUsuario.ForeColor = Color.LightGray;

                pnLogo.BackColor = Color.LightGray;
                pnLogo.Focus();
            }
            if (txtContraseña.Text != "CONTRASEÑA:" && txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA:";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
                
                pnLogo.BackColor = Color.LightGray;
                pnLogo.Focus();
            }
        }

            private void pnLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }


        //  ==================================================================================================
        //  ||============================================DISEÑO============================================||
        //  ==================================================================================================
        #endregion

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "USUARIO:")
            {
                if(txtContraseña.Text != "CONTRASEÑA:")
                {
                    UserModel user = new UserModel();
                    try
                    {
                        var validLogin = user.LoginUser(txtUsuario.Text, txtContraseña.Text);

                        if (validLogin == true)
                        {
                            this.Hide();
                            Welcome welcome = new Welcome();
                            welcome.ShowDialog();
                            FormPrincipal mainMenu = new FormPrincipal();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;

                        }
                        else
                        {
                            msgError("Nombre de Usuario o Contraseña Incorrecta, Intente nuevamente.");
                            
                            txtContraseña.Text = "CONTRASEÑA:";
                            txtContraseña.ForeColor = Color.LightGray;
                            txtContraseña.UseSystemPasswordChar = true;


                            txtUsuario.Text = "USUARIO:";
                            txtUsuario.ForeColor = Color.LightGray;

                            pnLogo.Focus();

                        }
                    }catch(SqlException ex)
                    {
                        msgError("Error SQL: " + ex.Message);
                    }
                }
                else msgError("Porfavor ingrese la contraseña");
            }
            else msgError("Porfavor ingrese el nombre de usuario.");
            
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Text = "USUARIO:";

            txtContraseña.Text = "CONTRASEÑA:";
            txtContraseña.UseSystemPasswordChar = true;

            this.Show();
            pnLogo.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resetPassword = new recoverPassword();
            resetPassword.ShowDialog();
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAcceder_Click(sender, e);
            }
        }
    }
}