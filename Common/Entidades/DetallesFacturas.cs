using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class DetallesFacturas
    {
        private int Id { get; set; }
        private decimal precio { get; set; }
        private int Cantidad { get; set; }
        private decimal Importe { get; set; }
        private decimal SubTotal { get; set; }
        private decimal Descuento { get; set; }
    }
}
