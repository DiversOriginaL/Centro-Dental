using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class EstadoSalud
    {
        private int EstadoSaludID { get; set; }
        private string? Enfermedad { get; set; }
        private string? Medicamento { get; set; }
        private string? Alergia { get; set; }
        private string? Embarazo { get; set; }
        
        Paciente paciente = new Paciente();

        #region Acceso a las propiedades
        public void SetEstadoSaludID(int estadosaludid)
        {
            paciente.SetEstadoSaludid(estadosaludid);
            EstadoSaludID = estadosaludid;
        }

        public void SetEnfermedad(string enfermedad)
        {
            Enfermedad = enfermedad;
        }
        public void SetMedicamento(string medicamento)
        {
            Medicamento = medicamento;
        }

        public void SetAlergia(string alergia)
        {
            Alergia = alergia;
        }

        public void SetEmbarazo(string embarazo)
        {
            Embarazo = embarazo;
        }

        public int GetEstadoSaludID()
        {
            return EstadoSaludID;
        }

        public string GetEnfermedad()
        {
            return Enfermedad ?? "";
        }

        public string GetMedicamento()
        {
            return Medicamento ?? "";
        }

        public string GetAlergia()
        {
            return Alergia ?? "";
        }

        public string GetEmbarazo()
        {
            return Embarazo ?? "";
        }
        #endregion
    }
}
