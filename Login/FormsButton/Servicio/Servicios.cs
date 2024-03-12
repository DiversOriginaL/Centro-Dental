using Presentacion.FormsButton.Servicios.FormHijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.FormsButton.Servicio
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //METODO PARA ABRIR FORMULARIO HIJO.
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Application.OpenForms.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterParent;

                formulario.ShowDialog();
                formulario.BringToFront();
            }
            else formulario.BringToFront();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CrudServicio>();

        }
    }
}
