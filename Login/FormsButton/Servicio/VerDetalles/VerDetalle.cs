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
using Domain.Domain;

namespace Presentacion.FormsButton.Servicio.VerDetalles
{
    public partial class VerDetalle : Form
    {
        public VerDetalle()
        {
            InitializeComponent();
        }

        #region MoverFormulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }

        #endregion


        private void VerDetalle_Load(object sender, EventArgs e)
        {
            mostrarDetalles();
            sendDtgvDatos();
        }

        CnFactura cnFactura = new CnFactura();
        string id;
        private void mostrarDetalles()
        {
            dtgvVerDetalles.DataSource = cnFactura.mostrarDetalles(id);
        }

        public void getFacturaID(string id)
        {
            this.id = id;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sendDtgvDatos()
        {
            List<string> Subtotales = new List<string>();

            foreach (DataGridViewRow row in dtgvVerDetalles.Rows)
            {
                if (!row.IsNewRow)
                {
                    Subtotales.Add(row.Cells[5].Value.ToString());
                }
            }

            string Total = cnFactura.ObtenerTotal(Subtotales);
            lblResultado.Text = Total;
        }
    }
}
