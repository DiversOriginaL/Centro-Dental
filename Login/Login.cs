using System.Runtime.InteropServices;
using Login.Domain;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //=======================================================DISEÑO==========================================

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd , int wmsg, IntPtr wParam, IntPtr lParam);


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO:")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
                pnLogo.BackColor = Color.WhiteSmoke;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO:";
                txtUsuario.ForeColor = Color.LightGray;
                pnLogo.BackColor = Color.LightGray;

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

            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA:";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
                pnLogo.BackColor = Color.LightGray;

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
        }

        private void pnLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }


        //  ==================================================================================================
        //  ||============================================DISEÑO============================================||
        //  ==================================================================================================


        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text != "USUARIO:")
            {
                if(txtContraseña.Text != "CONTRASEÑA:")
                {
                    UserModel user = new UserModel();

                    var validLogin = user.LoginUser(txtUsuario.Text, txtContraseña.Text);

                    if (validLogin == true)
                    {
                        Form form = new Form();
                        form.Text = "BIENVENIDO.";
                        form.ShowDialog();


                    }
                    else
                    {
                        msgError("Incorrect username or password entered. Please try again");
                        txtContraseña.Clear();
                        txtUsuario.Focus();

                    }

                }
                else msgError("Please enter password");
            }
            else msgError("Please enter username");
            
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = msg;
            lblErrorMessage.Visible = true;
        }
    }
}