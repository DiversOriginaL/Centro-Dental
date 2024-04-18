using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class DetallesFacturas
    {
        public int DetalleFacturaID { get; set; }
        public int ServicioID { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public int FacturaID { get; set; }


    }
}
