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
using Presentacion.FormsButton.Servicio;
using Presentacion.FormsButton.Servicio.FormHijos.CargarPaciente;

namespace Presentacion.FormsButton.Servicios.FormHijos
{
    public partial class CrudServicio : Form
    {
        public CrudServicio()
        {
            InitializeComponent();
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
            if(txtCosto.Text == "PRECIO:")
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
            if(txtCantidad.Text == "CANTIDAD:")
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
            this.id = id;
            this.pnombre = pnombre;
            this.papellido = papellido;
        }

        string? id;
        string? pnombre;
        string? papellido;
        List<int> servicioID = new List<int>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string servicio = cbServicio.Text.Trim();
            string precio = txtCosto.Text.Trim();
            string cantidad = txtCantidad.Text.Trim();
            string descuento = txtDescuento.Text.Trim();
            string importe = ""; string subtotal = "";

            if (id == null) id = "#";
            if (pnombre == null || papellido == null) { pnombre = "SIN"; papellido = "ESPECIFICAR"; }
            if (cbServicio.Text == "SERVICIO:" || cbServicio.Text == "") servicio = "SIN ESPECIFICAR";
            if (txtDescuento.Text == "DESCUENTO:" || txtDescuento.Text == "") descuento = "0.00";

            if (txtCosto.Text == "PRECIO:" || txtCosto.Text == "") 
            { 
                precio = "0.00"; 
                if(txtCantidad.Text == "CANTIDAD:" || txtCantidad.Text == "")
                {
                    cantidad = "0";
                    importe = "0";
                }
            }
            else
            {
                if(txtCantidad.Text == "CANTIDAD:" || txtCantidad.Text == "") cantidad="1";
                importe = cnFactura.ObtenerImporte(precio, cantidad);

            }

            subtotal = cnFactura.ObtenerSubTotal(importe, descuento);


            dtgvCrudServicio.Rows.Add(new object[] 
            { 
                id, pnombre + " " + papellido, servicio, precio, cantidad, importe, descuento, subtotal
            });

            if(cbServicio.SelectedValue != null && cbServicio.Text != "SERVICIO:" || cbServicio.Text != "")
            {
                servicioID.Add(Convert.ToInt32(cbServicio.SelectedValue.ToString()));
            }

            RestaurarForm();
            sendDtgvDatos();
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
            if (dtgvCrudServicio.SelectedRows.Count >= 0)
            {
                try
                {
                    dtgvCrudServicio.Rows.Remove(dtgvCrudServicio.CurrentRow);    
                    

                }catch(InvalidOperationException ex)
                {
                    MessageBox.Show("NO SELECCIONASTE LA FILA PARA PODER ELIMINARLA O NO EXISTE DICHA FILA... ERROR: " + ex.Message);
                }

                dtgvCrudServicio.ClearSelection();
                sendDtgvDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }

        private void sendDtgvDatos()
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
            lblResultado.Text = Total;
        }


        
        string operacion = "Insertar";

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if(operacion == "Insertar")
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
            else if(operacion == "Editar")
            {

            }
        }
    }
}
