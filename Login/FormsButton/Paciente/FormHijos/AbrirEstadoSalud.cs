using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion.FormsButton.Paciente.FormHijos
{
    public partial class AbrirEstadoSalud : Form
    {

        public AbrirEstadoSalud()
        {
            InitializeComponent();
            
        }

        #region MoverFormulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void AbrirEstadoSalud_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void verEstadoSalud(string enfermedad, string medicamento, string alergia, string embarazo)
        {
            lblEnfermedad.Text = enfermedad;
            lblMedicamento.Text = medicamento;
            lblAlergia.Text = alergia;
            lblEmbarazo.Text = embarazo;
        }
    }
}
