using Domain.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Presentacion.FormsButton.Reporte
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            cbFiltro.Text = "DIARIO";
            cIngresosDiarios.Series[0].Points.DataBindXY(cnReporte.getHoras(), cnReporte.getIngresoDiario());
            lblTotalRecaudado.Text = cnReporte.IngresoDiarioSumatoria();

        }

        CnReporte cnReporte = new CnReporte();
        
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltro.Items.Count != -1)
            {
                string? texto = cbFiltro.SelectedItem.ToString();

                if (texto == "DIARIO")
                {
                    cIngresosDiarios.Series[0].Points.DataBindXY(cnReporte.getHoras(), cnReporte.getIngresoDiario());
                    lblTotalRecaudado.Text = cnReporte.IngresoDiarioSumatoria();
                }
                else if (texto == "SEMANAL")
                {
                    cIngresosDiarios.Series[0].Points.DataBindXY(cnReporte.getDias(), cnReporte.getIngresoSemanal());
                    lblTotalRecaudado.Text = cnReporte.IngresoSemanalSumatoria();
                }
                else if (texto == "MENSUAL")
                {
                    cIngresosDiarios.Series[0].Points.DataBindXY(cnReporte.getSemanas(), cnReporte.getIngresoMensual());
                    lblTotalRecaudado.Text = cnReporte.IngresoMensualSumatoria();
                }
                else if (texto == "ANUAL")
                {
                    cIngresosDiarios.Series[0].Points.DataBindXY(cnReporte.getMeses(), cnReporte.getIngresoAnual());
                    lblTotalRecaudado.Text = cnReporte.IngresoAnualSumatoria();
                }
                else if (texto == "ANUALES")
                {
                    cIngresosDiarios.Series[0].Points.DataBindXY(cnReporte.getAños(), cnReporte.getIngresosAnuales());
                    lblTotalRecaudado.Text = cnReporte.IngresosAnualesSumatoria();
                }
                else
                {
                    cbFiltro.SelectedIndex = -1;
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
