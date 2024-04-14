using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess.DataAccess;

namespace Domain.Domain
{
    public class CnFactura
    {
        CdFactura cdFactura = new CdFactura();
        DataTable dt = new DataTable();

        public DataTable mostrarFacturas()
        {
            dt = cdFactura.mostrarFacturas();
            return dt;
        }


    }
}
