using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Presentacion;
using Presentacion.FormsButton.Servicio;
using Presentacion.FormsButton.Paciente;
using Presentacion.FormsButton.Reporte;
using Presentacion.FormsButton.Usuario;
using Common.Cache;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        private float originalAncho;
        public FormPrincipal()
        {
            InitializeComponent();

            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            originalAncho = (float)pnLeft.Width / Screen.PrimaryScreen.Bounds.Width;
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            areaTrabajo();
            LoadUserData();
            Permisos();
        }

        private void Permisos()
        {
            //DELEGANDO PERMISOS
            if (UserLoginCache.RolId() == Positions.DoctoraEncagada)
            {
                btnServicio.Visible = true;
                btnPaciente.Visible = true;
                btnReportes.Visible = true;
                btnUsuarios.Visible = false;
            }
            if(UserLoginCache.RolId() == Positions.Recepcionista)
            {
                btnServicio.Visible = true;
                btnPaciente.Visible = true;
                btnReportes.Visible = true;
                btnUsuarios.Visible = false;
            }
        }

        private void areaTrabajo()
        {
            // Obtener el �rea de trabajo de la pantalla principal
            Rectangle areaTrabajo = Screen.PrimaryScreen.WorkingArea;

            // Calcular el tama�o deseado del formulario como un porcentaje del �rea de trabajo
            double widthPercentage = 0.8; // 80% del ancho del �rea de trabajo
            double heightPercentage = 0.8; // 80% de la altura del �rea de trabajo

            int formWidth = (int)(areaTrabajo.Width * widthPercentage);
            int formHeight = (int)(areaTrabajo.Height * heightPercentage);

            // Configurar la posici�n y el tama�o del formulario
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                areaTrabajo.Left + (areaTrabajo.Width - formWidth) / 2,
                areaTrabajo.Top + (areaTrabajo.Height - formHeight) / 2
            );
            this.Size = new Size(formWidth, formHeight);

            // Opcional: Configurar el borde y el estado de la ventana
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
        }

        private void LoadUserData()
        {
            lblUsuario.Text = UserLoginCache.lblUser();
            lblEmail.Text = UserLoginCache.lblEmail();
        }

        #region Funcionalidades del formulario.
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMA�O A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    else
                        base.WndProc(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.pnContainer.Region = region;
            Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(200, 200, 200));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //----------------------MINIMIXAR-MAXIMIZAR/RESTAURAR-CERRAR----------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("�Estas seguro de que deseas cerrar la aplicacion?", "ADVERTENCIA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }
                
        private void btnMaximizar_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            { this.WindowState = FormWindowState.Normal; }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //FUNCION DE ARRASTRAR EL FORMULARIO.

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnUp_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        //METODO PARA ABRIR FORMULARIO DENTRO DEL PANEL.
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            Control.ControlCollection controls = pnRight.Controls;
            formulario = controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnRight.Controls.Add(formulario);
                pnRight.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();

                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else formulario.BringToFront();
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Servicios"] == null)
            {
                btnServicio.BackColor = Color.FromArgb(0, 136, 68);
                pnServicio.Visible = false;
            }

            if (Application.OpenForms["Pacientes"] == null)
            {
                btnPaciente.BackColor = Color.FromArgb(0, 136, 68);
                pnPaciente.Visible = false;
            }

            if (Application.OpenForms["Reportes"] == null)
            {
                btnReportes.BackColor = Color.FromArgb(0, 136, 68);
                pnReporte.Visible = false;
            }

            if (Application.OpenForms["Usuario"] == null)
            {
                btnUsuarios.BackColor = Color.FromArgb(0, 136, 68);
                pnUsuarios.Visible = false;
            }
        }


        private void btnServicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Servicios>();
            btnServicio.BackColor = Color.FromArgb(0, 204, 102);
            pnServicio.Visible = true;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Pacientes>();
            btnPaciente.BackColor = Color.FromArgb(0, 204, 102);
            pnPaciente.Visible = true;

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Reportes>();
            btnReportes.BackColor = Color.FromArgb(0, 204, 102);
            pnReporte.Visible = true;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Usuario>();
            btnUsuarios.BackColor = Color.FromArgb(0, 204, 102);
            pnUsuarios.Visible = true;

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnLeft.Width != 80)
            {
                pnLeft.Width = 80;
            }
            else if(pnLeft.Width == 80)
            {
                pnLeft.Width = (int)(Screen.PrimaryScreen.Bounds.Width * originalAncho);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�Estas seguro de que deseas cerrar sesion?", "ADVERTENCIA",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }

    }
}