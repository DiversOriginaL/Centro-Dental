namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO:")
            {
                txtUsuario.Text = "";

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO:";

            }
        }

        private void txtContrase�a_Enter(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "CONTRASE�A:")
            {
                txtContrase�a.Text = "";

            }
        }

        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (txtContrase�a.Text == "")
            {
                txtContrase�a.Text = "CONTRASE�A:";

            }

        }
    }
}