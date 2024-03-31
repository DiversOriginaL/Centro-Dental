using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entidades;
using System.Collections.Generic;
using DataAccess.DataAccess;

namespace Domain.Domain
{
    public class CnPaciente
    {
        CdPaciente paciente = new CdPaciente();
        public List<Paciente> ObtenerPacientes()
        {
            return paciente.mostrarPacientes();
        }
    }
}
