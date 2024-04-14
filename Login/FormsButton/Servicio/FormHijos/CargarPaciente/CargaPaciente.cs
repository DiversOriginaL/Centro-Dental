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
using Domain.Domain;
using Presentacion.FormsButton.Servicios.FormHijos;

namespace Presentacion.FormsButton.Servicio.FormHijos.CargarPaciente
{
    public partial class CargaPaciente : Form
    {
        public CargaPaciente()
        {
            InitializeComponent();
        }

        #region MoverFormulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void dtgvCargarPaciente_MouseDown(object sender, MouseEventArgs e)
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

        public CrudServicio crudServicioForm;
        public CargaPaciente(CrudServicio crudServicioForm) : this()
        {
            this.crudServicioForm = crudServicioForm;
        }

        private void CargaPaciente_Load(object sender, EventArgs e)
        {
            mostrarPacientes();
        }

        private void mostrarPacientes()
        {
            CnPaciente cnPaciente = new CnPaciente();
            dtgvCargarPaciente.DataSource = cnPaciente.mostrarPacientes("");
            dtgvCargarPaciente.ClearSelection();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dtgvCargarPaciente.SelectedRows.Count > 0)
            {
                string id = dtgvCargarPaciente.CurrentRow.Cells["ID"].Value.ToString();
                string pnombre = dtgvCargarPaciente.CurrentRow.Cells["PNombre"].Value.ToString();
                string papellido = dtgvCargarPaciente.CurrentRow.Cells["PApellido"].Value.ToString();

                getid(id, pnombre, papellido);

                this.Close();
            }
            else
            {
                MessageBox.Show("NO HA SELECCIONADO NINGUNA FILA.");
            }
        }

        private void getid(string id, string pnombre, string papellido)
        {
            crudServicioForm.getid(id, pnombre, papellido);
        }

    }
}
