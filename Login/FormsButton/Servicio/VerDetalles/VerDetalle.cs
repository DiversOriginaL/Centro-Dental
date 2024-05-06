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
using Presentacion.FormsButton.Servicios.FormHijos;
using Common.Entidades;

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
            sendDtgvDatoTotal();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        CnFactura cnFactura = new CnFactura();
        string id;
        private void mostrarDetalles()
        {
            dtgvVerDetalles.DataSource = cnFactura.mostrarDetalles(id);
        }
        private void sendDtgvDatoTotal()
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
        public void getFacturaID(string id)
        {
            this.id = id;
        }

        public void cargarDetallesDtgv(CrudServicio crudServicioForm, string id, string pacienteID, string paciente)
        {
            dtgvVerDetalles.DataSource = cnFactura.mostrarDetalles(id);

            List<string> valoresExtraidos = new List<string>();
            List<DetallesFacturas> detalle = new List<DetallesFacturas>();

            foreach (DataGridViewRow fila in dtgvVerDetalles.Rows)
            {
                // Verificar si la fila no es la fila de encabezado y si el valor de la celda no es nulo
                if (!fila.IsNewRow && fila.Cells["Servicio"].Value != null)
                {
                    string valorCelda = fila.Cells["Servicio"].Value.ToString();
                    valoresExtraidos.Add(valorCelda);
                }

                var datos = new DetallesFacturas()
                {
                    Precio = Convert.ToDecimal(fila.Cells["Precio"].Value),
                    Cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value),
                    Importe = Convert.ToDecimal(fila.Cells["Importe"].Value),
                    Descuento = Convert.ToDecimal(fila.Cells["Descuento"].Value),
                    SubTotal = Convert.ToDecimal(fila.Cells["SubTotal"].Value)
                };
                detalle.Add(datos);

            }

            crudServicioForm.recibirDetalles(id, valoresExtraidos, detalle, pacienteID, paciente);

        }
    }
}
