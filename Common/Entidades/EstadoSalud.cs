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
        private string Enfermedad { get; set; }
        private string Medicamento { get; set; }
        private string Alergia { get; set; }
        private string Embarazo { get; set; }

        public void SetEstadoSaludID(int id)
        {
            EstadoSaludID = id;
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

        public int GetEstadoSaludID() => EstadoSaludID;
        public string GetEnfermedad() => Enfermedad;
        public string GetMedicamento() => Medicamento;
        public string GetAlergia() => Alergia;
        public string GetEmbarazo() => Embarazo;
    }
}
