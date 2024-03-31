using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class EstadoSalud
    {
        private int _estadosaludid { get; set; }
        private string? _enfermedad { get; set; }
        private string? _medicamento { get; set; }
        private string? _alergia { get; set; }
        private string? _embarazo { get; set; }

        #region Acceso a las propiedades
        public void Setestadosaludid(int id)
        {
            _estadosaludid = id;
        }

        public void Setenfermedad(string enfermedad)
        {
            _enfermedad = enfermedad;
        }
        public void Setmedicamento(string medicamento)
        {
            _medicamento = medicamento;
        }

        public void Setalergia(string alergia)
        {
            _alergia = alergia;
        }

        public void Setembarazo(string embarazo)
        {
            _embarazo = embarazo;
        }

        public int GetId()
        {
            return _estadosaludid;
        }

        public string GetEnfermedad()
        {
            return _enfermedad ?? "";
        }

        public string GetMedicamento()
        {
            return _medicamento ?? "";
        }

        public string GetAlergia()
        {
            return _alergia ?? "";
        }

        public string GetEmbarazo()
        {
            return _embarazo ?? "";
        }
        #endregion
    }
}
