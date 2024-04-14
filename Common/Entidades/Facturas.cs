using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Facturas
    {
        private int FacturaID { get; set; }
        private decimal Total { get; set; }
        private DateTime Fecha { get; set; }

        public void SetFacturaID(int FacturaID)
        {
            this.FacturaID = FacturaID;
        }

        public void SetTotal(decimal Total)
        {
            this.Total = Total;
        }

        public void SetFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }

        public int GetFacturaID() => this.FacturaID;
        public decimal GetTotal() => this.Total;
        public DateTime GetFecha() => this.Fecha;

    }
}
