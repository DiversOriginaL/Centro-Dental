using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Facturas
    {
        public int FacturaID { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }

        public int PacienteID { get; set; }
        public int UsuarioID { get; set; }

    }
}
