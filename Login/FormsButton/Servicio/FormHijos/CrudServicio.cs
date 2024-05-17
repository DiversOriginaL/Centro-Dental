using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Entidades;
using Domain.Domain;
using Presentacion.FormsButton.Servicio.FormHijos.CargarPaciente;
using System.Drawing.Printing;
using Common.Cache;

namespace Presentacion.FormsButton.Servicios.FormHijos
{
    public partial class CrudServicio : Form
    {

        public CrudServicio()
        {
            InitializeComponent();
        }

        public Servicio.Servicios servicioForm;
        public CrudServicio(Servicio.Servicios servicioForm) : this()
        {
            this.servicioForm = servicioForm;
        }
        private void CrudServicio_Load(object sender, EventArgs e)
        {
            cargarServicios();
        }

        #region MoverFormulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void CrudServicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }

        private void dtgvCrudServicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }

        private void pnDown_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        #endregion

        #region EfectoPlaceHolder

        private void cbServicio_Enter(object sender, EventArgs e)
        {
            if (cbServicio.Text == "SERVICIO:")
            {
                cbServicio.Text = "";
                cbServicio.ForeColor = Color.Black;
            }
        }

        private void cbServicio_Leave(object sender, EventArgs e)
        {
            if (cbServicio.Text == "")
            {
                cbServicio.Text = "SERVICIO:";
                cbServicio.ForeColor = Color.Silver;

            }
        }

        private void txtCosto_Enter(object sender, EventArgs e)
        {
            if (txtCosto.Text == "PRECIO:")
            {
                txtCosto.Text = "";
                txtCosto.ForeColor = Color.Black;
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (txtCosto.Text == "")
            {
                txtCosto.Text = "PRECIO:";
                txtCosto.ForeColor = Color.Silver;
            }
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "CANTIDAD:")
            {
                txtCantidad.Text = "";
                txtCantidad.ForeColor = Color.Black;
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "CANTIDAD:";
                txtCantidad.ForeColor = Color.Silver;
            }
        }

        private void txtDescuento_Enter(object sender, EventArgs e)
        {
            if (txtDescuento.Text == "DESCUENTO:")
            {
                txtDescuento.Text = "";
                txtDescuento.ForeColor = Color.Black;
            }

        }

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if (txtDescuento.Text == "")
            {
                txtDescuento.Text = "DESCUENTO:";
                txtDescuento.ForeColor = Color.Silver;
            }

        }

        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbServicio.Text = "";
            txtCosto.Text = "";
            txtCantidad.Text = "";
            txtDescuento.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cbServicio.Text = "SERVICIO:";
            txtCosto.Text = "PRECIO:";
            txtCantidad.Text = "CANTIDAD:";
            txtDescuento.Text = "DESCUENTO:";

            this.Close();
        }
        private void btnCargarPaciente_Click(object sender, EventArgs e)
        {
            AbrirCargarPaciente<CargaPaciente>(this);
        }

        private void AbrirCargarPaciente<MiForm>(CrudServicio crudservicio) where MiForm : Form
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = Activator.CreateInstance(typeof(MiForm)) as Form;
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterScreen;

                if (formulario is CargaPaciente crudservicioform)
                {
                    crudservicioform.crudServicioForm = crudservicio;
                }

                formulario.ShowDialog();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        CnFactura cnFactura = new CnFactura();
        private void cargarServicios()
        {
            cbServicio.DataSource = cnFactura.cargarServicios();
            cbServicio.DisplayMember = "Servicio";
            cbServicio.ValueMember = "ServicioID";
            cbServicio.SelectedIndex = -1;

        }

        private void cbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServicio.SelectedIndex != -1)
            {
                string servicio = cbServicio.Text;

                string precio = cnFactura.ObtenerPrecio(servicio);
                txtCosto.Text = precio;

                cbServicio.ForeColor = Color.Black;
                txtCosto.ForeColor = Color.Black;
            }
        }

        public void getid(string id, string pnombre, string papellido)
        {
            this.pacienteid = id;
            this.pnombre = pnombre;
            this.papellido = papellido;
        }

        string? pacienteid;
        string? pnombre;
        string? papellido;
        List<int> servicioID = new List<int>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (pacienteid == null)
            {
                MessageBox.Show("Por favor seleccione un paciente antes de agregar un servicio. ", "Informacion", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbServicio.Text == "SERVICIO:" || cbServicio.Text == "")
            {
                MessageBox.Show("Por favor seleccione un servicio antes de intentar agregar una fila a la factura. ", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            string servicio = cbServicio.Text.Trim();
            string precio = txtCosto.Text.Trim();
            string cantidad = txtCantidad.Text.Trim();
            string descuento = txtDescuento.Text.Trim();
            string importe = ""; string subtotal = "";


            if (pnombre == null || papellido == null) { pnombre = "SIN"; papellido = "ESPECIFICAR"; }
            if (txtDescuento.Text == "DESCUENTO:" || txtDescuento.Text == "") descuento = "0.00";
            if (operacion == "Editar") pacienteid = this.pacienteID;
            
            if (txtCosto.Text == "PRECIO:" || txtCosto.Text == "")
            {
                precio = "0.00";

                if (txtCantidad.Text == "CANTIDAD:" || txtCantidad.Text == "")
                {
                    cantidad = "0";
                    importe = "0";
                }
            }
            else
            {
                if (txtCantidad.Text == "CANTIDAD:" || txtCantidad.Text == "") cantidad = "1";
                importe = cnFactura.ObtenerImporte(precio, cantidad);

            }

            subtotal = cnFactura.ObtenerSubTotal(importe, descuento);


            dtgvCrudServicio.Rows.Add(new object[]
            {
                pacienteid, pnombre + " " + papellido, servicio, precio, cantidad, importe, descuento, subtotal
            });

            if ((cbServicio.SelectedValue != null && cbServicio.Text != "SERVICIO:" || cbServicio.Text != "") && (operacion == "Insertar"))
            {
                servicioID.Add(Convert.ToInt32(cbServicio.SelectedValue.ToString()));
            }

            if (!(servicioID.Count > 0) && (operacion == "Editar"))
            {
                valoresCoincidentes.Add(Convert.ToInt32(cbServicio.SelectedValue.ToString()));
            }

            RestaurarForm();
            calcularTotal();
        }

        private void RestaurarForm()
        {
            cbServicio.Text = "SERVICIO:";
            txtCosto.Text = "PRECIO:";
            txtCantidad.Text = "CANTIDAD:";
            txtDescuento.Text = "DESCUENTO:";

            dtgvCrudServicio.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvCrudServicio.SelectedRows.Count > 0)
            {
                try
                {
                    int fila = dtgvCrudServicio.SelectedRows[0].Index;
                    dtgvCrudServicio.Rows.Remove(dtgvCrudServicio.CurrentRow);

                    // Eliminar el elemento correspondiente en la lista servicioID
                    if (servicioID.Count > 0 && fila < servicioID.Count)
                    {
                        servicioID.RemoveAt(fila);
                    }

                    // Eliminar el elemento correspondiente en la lista valoresCoincidentes
                    if (valoresCoincidentes.Count > 0 && fila < valoresCoincidentes.Count)
                    {
                        valoresCoincidentes.RemoveAt(fila);
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("NO SELECCIONASTE LA FILA PARA PODER ELIMINARLA O NO EXISTE DICHA FILA... ERROR: " + ex.Message);
                }

                dtgvCrudServicio.ClearSelection();
                calcularTotal();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void calcularTotal()
        {
            List<string> Subtotales = new List<string>();

            foreach (DataGridViewRow row in dtgvCrudServicio.Rows)
            {
                if (!row.IsNewRow)
                {
                    Subtotales.Add(row.Cells[7].Value.ToString());
                }
            }

            string Total = cnFactura.ObtenerTotal(Subtotales);

            if (cbItbis.Checked)
            {
                decimal totaldecimal = Convert.ToDecimal(Total);
                decimal itbis = totaldecimal * 0.18m;
                decimal itbisAplicado = totaldecimal + itbis;

                lblResultado.Text = itbisAplicado.ToString("N2");
            }
            else
            {
                lblResultado.Text = Total;
            }

        }

        private void cbItbis_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbItbis.Checked)
            {
                calcularTotal();
            }
            else
            {
                calcularTotal();
            }
        }

        public string operacion = "Insertar";
        public Servicio.Servicios FormularioPadre { get; set; }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (operacion == "Insertar")
            {
                string PacienteID = dtgvCrudServicio.CurrentRow.Cells["ID"].Value.ToString();
                string Total = lblResultado.Text;

                List<DetallesFacturas> detalle = new List<DetallesFacturas>();


                foreach (DataGridViewRow dtgv in dtgvCrudServicio.Rows)
                {

                    var datos = new DetallesFacturas()
                    {
                        Precio = Convert.ToDecimal(dtgv.Cells["Precio"].Value),
                        Cantidad = Convert.ToInt32(dtgv.Cells["Cantidad"].Value),
                        Importe = Convert.ToDecimal(dtgv.Cells["Importe"].Value),
                        Descuento = Convert.ToDecimal(dtgv.Cells["Descuento"].Value),
                        SubTotal = Convert.ToDecimal(dtgv.Cells["SubTotal"].Value)
                    };
                    detalle.Add(datos);
                }

                cnFactura.insertarFactura(detalle, servicioID, Total, PacienteID);
                MessageBox.Show("Factura realizada con exito.");

                var service = new Servicio.Servicios();
                this.Close();

                service.actualizardtgv();
            }
            else if (operacion == "Editar")
            {
                string total = lblResultado.Text;

                List<DetallesFacturas> detalle = new List<DetallesFacturas>();

                foreach (DataGridViewRow dtgv in dtgvCrudServicio.Rows)
                {

                    var datos = new DetallesFacturas()
                    {
                        Precio = Convert.ToDecimal(dtgv.Cells["Precio"].Value),
                        Cantidad = Convert.ToInt32(dtgv.Cells["Cantidad"].Value),
                        Importe = Convert.ToDecimal(dtgv.Cells["Importe"].Value),
                        Descuento = Convert.ToDecimal(dtgv.Cells["Descuento"].Value),
                        SubTotal = Convert.ToDecimal(dtgv.Cells["SubTotal"].Value)
                    };
                    detalle.Add(datos);
                }

                cnFactura.EditarFactura(facturaid, detalle, valoresCoincidentes, total, pacienteID);
                MessageBox.Show("Factura editada con exito.");
                operacion = "Insertar";

                this.Close();

            }
            FormularioPadre.actualizardtgv();
        }

        string facturaid;
        string pacienteID;
        List<int> valoresCoincidentes = new List<int>();


        public void recibirDetalles(string facturaid, List<string> services, List<DetallesFacturas> detalles, string pacienteID, string paciente)
        {
            this.facturaid = facturaid;
            this.pacienteID = pacienteID;

            for (int i = 0; i < services.Count; i++)
            {
                string servicio = services[i];
                DetallesFacturas detalle = detalles[i];

                int rowIndex = dtgvCrudServicio.Rows.Add();

                dtgvCrudServicio.Rows[rowIndex].Cells["ID"].Value = pacienteID;
                dtgvCrudServicio.Rows[rowIndex].Cells["Paciente"].Value = paciente;
                dtgvCrudServicio.Rows[rowIndex].Cells["Servicio"].Value = servicio;
                dtgvCrudServicio.Rows[rowIndex].Cells["Precio"].Value = detalle.Precio;
                dtgvCrudServicio.Rows[rowIndex].Cells["Cantidad"].Value = detalle.Cantidad;
                dtgvCrudServicio.Rows[rowIndex].Cells["Importe"].Value = detalle.Importe;
                dtgvCrudServicio.Rows[rowIndex].Cells["Descuento"].Value = detalle.Descuento;
                dtgvCrudServicio.Rows[rowIndex].Cells["SubTotal"].Value = detalle.SubTotal;
            }

            calcularTotal();


            //EXTRAYENDO LOS VALORES DE LOS SERVICIOS.
            for (int i = 0; i < services.Count; i++)
            {
                string servicio = services[i].ToString();
                int contador = 1;

                foreach (var item in cbServicio.Items)
                {
                    string textoComboBox = cbServicio.GetItemText(item);

                    if (string.Equals(servicio, textoComboBox, StringComparison.OrdinalIgnoreCase))
                    {
                        valoresCoincidentes.Add(contador);
                    }
                    contador++;
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            pdImprimir = new PrintDocument();

            PrinterSettings ps = new PrinterSettings();

            pdImprimir.PrinterSettings = ps;
            pdImprimir.PrintPage += Imprimir;
            pdImprimir.Print();

        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font subtitulo = new Font("Times New Roman", 9, FontStyle.Bold, GraphicsUnit.Point);
            Font cuerpo = new Font("Times New Roman", 9, FontStyle.Regular, GraphicsUnit.Point);
            Font small = new Font("Times New Roman", 7, FontStyle.Bold, GraphicsUnit.Point);

            int width = 300;
            int height = 1000;
            int y = 0;
            int x = 0;

            string direccion = @"C:\Miguel Ballester, Santo Domingo Este\Republica Dominicana";
            string contacto = "Contacto: +1(829)-998-8609";
            string rnc = "RNC: 22300244161";
            string fecha = "Fecha: " + DateTime.Now.ToString();
            string remitente = "Remitente: " + UserLoginCache.getUser();

            e.Graphics.DrawString(direccion, cuerpo, Brushes.Black, new RectangleF(x, y, width, height));
            e.Graphics.DrawString(contacto, cuerpo, Brushes.Black, new RectangleF(x, y += 30, width, height));
            e.Graphics.DrawString(fecha, cuerpo, Brushes.Black, new RectangleF(x, y += 15, width, height));

            if (remitente != null)
            {
                e.Graphics.DrawString(remitente, cuerpo, Brushes.Black, new RectangleF(x, y += 15, width, height));
            }

            e.Graphics.DrawString(rnc, cuerpo, Brushes.Black, new RectangleF(x, y += 15, width, height));

            e.Graphics.DrawString("-----------------------CONSUMO------------------------------", subtitulo, Brushes.Black, new RectangleF(x += 5, y += 30, width, height));
            e.Graphics.DrawString("Servicio:     Precio:     Cantidad:     Importe:", subtitulo, Brushes.Black, new RectangleF(x += 10, y += 20, width, height));
            e.Graphics.DrawString("------------------------------------------------------------", subtitulo, Brushes.Black, new RectangleF(x, y += 10, width, height));

            if (dtgvCrudServicio.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgvCrudServicio.Rows)
                {
                    string servicio = row.Cells["Servicio"].Value.ToString();
                    string precio = row.Cells["Precio"].Value.ToString();
                    string cantidad = row.Cells["Cantidad"].Value.ToString();
                    string Importe = row.Cells["Importe"].Value.ToString();

                    e.Graphics.DrawString(servicio + "     " + precio + "     " + cantidad + "     " + Importe,
                        small, Brushes.Black, new RectangleF(x, y += 15, width, height));

                }

            }
            e.Graphics.DrawString("-------------------------------------------------------", subtitulo, Brushes.Black, new RectangleF(x, y += 20, width, height));
            e.Graphics.DrawString("SubTotal: DOP$ " + lblResultado.Text, cuerpo, Brushes.Black, new RectangleF(x, y += 15, width, height));

            double sumatoria = 0.00;

            foreach (DataGridViewRow row in dtgvCrudServicio.Rows)
            {
                double descuento = 0;
                if (Convert.ToDouble(row.Cells["Descuento"].Value.ToString()) > 0)
                {
                    descuento = Convert.ToDouble(row.Cells["Descuento"].Value.ToString());
                }

                sumatoria += descuento;
            }

            e.Graphics.DrawString("Descuento: DOP$ " + sumatoria.ToString(), cuerpo, Brushes.Black, new RectangleF(x, y += 20, width, height));
            e.Graphics.DrawString("Total: DOP$ " + lblResultado.Text, cuerpo, Brushes.Black, new RectangleF(x, y += 20, width, height));
            e.Graphics.DrawString("------UN PLACER HABERLE ASISTIDO------\n\n", subtitulo, Brushes.Black, new RectangleF(x, y += 120, width, height));
        }

        private void soloNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }
    }
}
