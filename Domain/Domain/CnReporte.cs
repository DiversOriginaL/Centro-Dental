using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using DataAccess.DataAccess;

namespace Domain.Domain
{
    public class CnReporte
    {
        CdReporte cdreporte = new CdReporte();

        //DIARIO
        public ArrayList getHoras()
        {
            cdreporte.IngresoDiario();
            return cdreporte.getHoras();
        }

        public ArrayList getIngresoDiario()
        {
            return cdreporte.getIngresoDiario();
        }

        public string IngresoDiarioSumatoria()
        {
            ArrayList array = cdreporte.getIngresoDiario();

            decimal sumatoria = 0;

            foreach (decimal list in array)
            {
                sumatoria += list;
            }

            return sumatoria.ToString();
        }

        //SEMANAL
        public ArrayList getDias()
        {
            cdreporte.IngresoSemanal();
            return cdreporte.getDias();
        }
        public ArrayList getIngresoSemanal()
        {
            return cdreporte.getIngresoSemanal();
        }

        public string IngresoSemanalSumatoria()
        {
            ArrayList array = cdreporte.getIngresoSemanal();

            decimal sumatoria = 0;

            foreach (decimal list in array)
            {
                sumatoria += list;
            }

            return sumatoria.ToString();
        }

        //MENSUAL
        public ArrayList getSemanas()
        {
            cdreporte.IngresoMensual();
            return cdreporte.getSemanas();
        }
        public ArrayList getIngresoMensual()
        {
            return cdreporte.getIngresoMensual();
        }
        public string IngresoMensualSumatoria()
        {
            ArrayList array = cdreporte.getIngresoMensual();

            decimal sumatoria = 0;

            foreach (decimal list in array)
            {
                sumatoria += list;
            }

            return sumatoria.ToString();
        }

        //ANUAL
        public ArrayList getMeses()
        {
            cdreporte.IngresoAnual();
            return cdreporte.getMeses();
        }
        public ArrayList getIngresoAnual()
        {
            return cdreporte.getIngresoAnual();
        }

        public string IngresoAnualSumatoria()
        {
            ArrayList array = cdreporte.getIngresoAnual();

            decimal sumatoria = 0;

            foreach (decimal list in array)
            {
                sumatoria += list;
            }

            return sumatoria.ToString();
        }

        //ANUALES.
        public ArrayList getAños()
        {
            cdreporte.IngresosAnuales();
            return cdreporte.getAño();
        }
        public ArrayList getIngresosAnuales()
        {
            return cdreporte.getIngresosAnuales();
        }
        public string IngresosAnualesSumatoria()
        {
            ArrayList array = cdreporte.getIngresosAnuales();

            decimal sumatoria = 0;
            
            foreach (decimal list in array)
            {
                sumatoria += list;
            }

            return sumatoria.ToString();
        }
    }
}
