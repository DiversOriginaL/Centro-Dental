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
        private decimal Precio { get; set; }
        private int Cantidad { get; set; }
        private decimal Importe { get; set; }
        private decimal SubTotal { get; set; }
        private decimal Descuento { get; set; }

        public void SetId(int Id)
        {
            this.Id = Id;
        }
        public void SetPrecio(decimal Precio)
        {
            this.Precio = Precio;
        }
        public void SetCantidad(int Cantidad)
        {
            this.Cantidad = Cantidad;
        }
        public void SetImporte(decimal Importe)
        {
            this.Importe = Importe;
        }
        public void SetSubTotal(decimal SubTotal)
        {
            this.SubTotal = SubTotal;
        }
        public void SetDescuento(decimal Descuento)
        {
            this.Descuento = Descuento;
        }

        public int GetID() => Id;
        public decimal GetPrecio() => Precio;
        public decimal GetCantidad() => Cantidad;
        public decimal GetImporte() => Importe;
        public decimal GetSubTotal() => SubTotal;
        public decimal GetDescuento() => Descuento;
    }
}
