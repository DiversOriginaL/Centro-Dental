using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Servicios
    {
        private int ServicioID { get; set; }
        private string Servicio { get; set; }
        private decimal Precio { get; set; }

        public void SetServicioID(int ServicioID)
        {
            this.ServicioID = ServicioID;
        }
        public void SetServicio(string Servicio)
        {
            this.Servicio = Servicio;
        }
        public void SetPrecio(decimal Precio)
        {
            this.Precio = Precio;
        }

        public int GetServicioID() => ServicioID;
        public string GetServicio() => Servicio;
        public decimal GetPrecio() => Precio;

    }
}
