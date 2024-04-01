using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entidades;
using System.Collections.Generic;
using DataAccess.DataAccess;
using System.Data;


namespace Domain.Domain
{
    public class CnPaciente
    {
        CdPaciente paciente = new CdPaciente();
        public DataTable ObtenerPacientes()
        {
            return paciente.mostrarPacientes();
        }
    }
}
