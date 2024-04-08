using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.FormsButton.Paciente.FormHijos
{
    public partial class AbrirEstadoSalud : Form
    {

        public AbrirEstadoSalud()
        {
            InitializeComponent();
            
        }

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
