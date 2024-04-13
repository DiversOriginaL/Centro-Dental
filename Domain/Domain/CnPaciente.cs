using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entidades;
using System.Collections.Generic;
using DataAccess.DataAccess;
using System.Data;
using Common.Cache;


namespace Domain.Domain
{
    public class CnPaciente
    {
        CdPaciente cdpaciente = new CdPaciente();
        
        Contactos contacto = new Contactos();
        Ubicaciones ubicacion = new Ubicaciones();
        EstadoSalud estadosalud = new EstadoSalud();
        Paciente paciente = new Paciente();


        public DataTable mostrarPacientes(string filtro)
        {
            return cdpaciente.mostrarPacientes(filtro);
        }

        public void insertarPaciente
            (
            string pnombre, string snombre, string papellido, string sapellido, string edad, object sexo,
            string celular, string telefono, object provincia, string sector, string calle, string numcasa, string enfermedad,
            string medicamento, string alergia, string embarazo
            )
        {
            paciente.SetPNombre(pnombre);
            paciente.SetSNombre(snombre);
            paciente.SetPApellido(papellido);
            paciente.SetSApellido(sapellido);
            paciente.SetEdad(edad);
            paciente.SetSexo(Convert.ToChar(sexo));
            contacto.SetCelular(celular);
            contacto.SetTelefono(telefono);
            ubicacion.SetProvincia(provincia.ToString());
            ubicacion.SetSector(sector);
            ubicacion.SetCalle(calle);
            ubicacion.SetNumCasa(numcasa);
            estadosalud.SetEnfermedad(enfermedad);
            estadosalud.SetMedicamento(medicamento);
            estadosalud.SetAlergia(alergia);
            estadosalud.SetEmbarazo(embarazo);

            cdpaciente.InsertarPaciente(paciente, contacto, ubicacion, estadosalud);
        }

        public void editarPaciente
            (
            string id, string pnombre, string snombre, string papellido, string sapellido, string edad, object sexo,
            string celular, string telefono, object provincia, string sector, string calle, string numcasa, string enfermedad,
            string medicamento, string alergia, string embarazo
            )
        {
            paciente.SetPacienteID(Convert.ToInt32(id));
            paciente.SetPNombre(pnombre);
            paciente.SetSNombre(snombre);
            paciente.SetPApellido(papellido);
            paciente.SetSApellido(sapellido);
            paciente.SetEdad(edad);
            paciente.SetSexo(Convert.ToChar(sexo));
            contacto.SetCelular(celular);
            contacto.SetTelefono(telefono);
            ubicacion.SetProvincia(provincia.ToString());
            ubicacion.SetSector(sector);
            ubicacion.SetCalle(calle);
            ubicacion.SetNumCasa(numcasa);
            estadosalud.SetEnfermedad(enfermedad);
            estadosalud.SetMedicamento(medicamento);
            estadosalud.SetAlergia(alergia);
            estadosalud.SetEmbarazo(embarazo);

            cdpaciente.editarPaciente(paciente, contacto, ubicacion, estadosalud);
        }

        public void eliminarPaciente(string PacienteID)
        {
            cdpaciente.eliminarPaciente(Convert.ToInt32(PacienteID));
        }
    }
}
