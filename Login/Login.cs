using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Login.Domain.Domain;
using Presentacion.RecuperarContrase�a;
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
        //=======================================================DISE�O==========================================

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

        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "CONTRASE�A:")
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.White;
                txtContrase�a.UseSystemPasswordChar = false;
                pnLogo.BackColor = Color.WhiteSmoke;

                lblErrorMessage.Visible = false;
            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "CONTRASE�A:";
                txtContrase�a.ForeColor = Color.LightGray;
                txtContrase�a.UseSystemPasswordChar = true;
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
            if (txtContrase�a.Text != "CONTRASE�A:" && txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "CONTRASE�A:";
                txtContrase�a.ForeColor = Color.LightGray;
                txtContrase�a.UseSystemPasswordChar = true;
                
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
        //  ||============================================DISE�O============================================||
        //  ==================================================================================================
        #endregion

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "USUARIO:")
            {
                if(txtContrase�a.Text != "CONTRASE�A:")
                {
                    UserModel user = new UserModel();
                    try
                    {
                        var validLogin = user.LoginUser(txtUsuario.Text, txtContrase�a.Text);

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
                            msgError("Nombre de Usuario o Contrase�a Incorrecta, Intente nuevamente.");
                            
                            txtContrase�a.Text = "CONTRASE�A:";
                            txtContrase�a.ForeColor = Color.LightGray;
                            txtContrase�a.UseSystemPasswordChar = true;


                            txtUsuario.Text = "USUARIO:";
                            txtUsuario.ForeColor = Color.LightGray;

                            pnLogo.Focus();

                        }
                    }catch(SqlException ex)
                    {
                        msgError("Error SQL: " + ex.Message);
                    }
                }
                else msgError("Porfavor ingrese la contrase�a");
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

            txtContrase�a.Text = "CONTRASE�A:";
            txtContrase�a.UseSystemPasswordChar = true;

            this.Show();
            pnLogo.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resetPassword = new recoverPassword();
            resetPassword.ShowDialog();
        }

        private void txtContrase�a_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAcceder_Click(sender, e);
            }
        }
    }
}