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


        #region Acceso a las propiedades.

        public void Setubicacionid(int ubucacionid)
        {
            _ubicacionid = ubucacionid;
        }

        public void Setciudad(string ciudad)
        {
            _ciudad = ciudad;
        }
        public void Setsector(string sector)
        {
            _sector = sector;
        }

        public void Setcalle(string calle)
        {
            _calle = calle;
        }

        public void Setnumerocasa(string numerocasa)
        {
            _numerocasa = numerocasa;
        }


        public int Getubicacionid()
        {
            return _ubicacionid;
        }

        public string Getciudad()
        {
            return _ciudad;
        }
        public string Getsector()
        {
            return _sector;
        }

        public string Getcalle()
        {
            return _calle;
        }

        public string Getnumerocasa()
        {
            return _numerocasa;
        }

        #endregion
    }
}
