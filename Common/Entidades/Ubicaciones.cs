using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Ubicaciones
    {
        private int _ubicacionid;

        private string _ciudad { get; set; }
        private string _sector { get; set; }
        private string _calle { get; set; }
        private string _numerocasa { get; set; }

        Paciente paciente = new Paciente();

        #region Acceso a las propiedades.

        public void SetUbicacionID(int ubucacionid)
        {
            paciente.SetUicacionID(ubucacionid);
            _ubicacionid = ubucacionid;
        }

        public void SetCiudad(string ciudad)
        {
            _ciudad = ciudad;
        }
        public void SetSector(string sector)
        {
            _sector = sector;
        }

        public void SetCalle(string calle)
        {
            _calle = calle;
        }

        public void SetNumeroCasa(string numerocasa)
        {
            _numerocasa = numerocasa;
        }


        public int GetUbicacionid()
        {
            return _ubicacionid;
        }

        public string GetCiudad()
        {
            return _ciudad;
        }
        public string GetSector()
        {
            return _sector;
        }

        public string GetCalle()
        {
            return _calle;
        }

        public string GetNumeroCasa()
        {
            return _numerocasa;
        }

        #endregion
    }
}
