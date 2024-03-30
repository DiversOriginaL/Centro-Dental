using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Pacientes
    {
        private int _pacienteid;
        private string _pnombre { get; set; }
        private string _snombre { get; set; }
        private string _papellido { get; set; }
        private string _sapellido { get; set; }
        private int _edad { get; set; }
        private int _contactoid { get; set; }
        private int _ubicacionid { get; set; }
        private int _usuarioid { get; set; }
        private int _estadosaludid { get; set; }

        private DateTime _fecha;

        #region acceso a las propiedades
        public int Getid()
        {
            return _pacienteid;
        }

        public void Setid(int value)
        {
            _pacienteid = value;
        }

        public string Getpnombre()
        {
            return _pnombre;
        }

        public void Setpnombre(string pnombre)
        {
            this._pnombre = pnombre;
        }

        public string Getsnombre()
        {
            return _snombre;
        }

        public void Setsnombre(string snombre)
        {
            _snombre = snombre;
        }

        public string Getpapellido()
        {
            return _papellido;
        }

        public void Setpapellido(string papellido)
        {
            _papellido = papellido;
        }

        public string Getsapellido()
        {
            return _sapellido;
        }

        public void Setsapellido(string papellido)
        {
            _sapellido = papellido;
        }

        public int GetEdad()
        {
            return _edad;
        }

        public void SetEdad(int edad)
        {
            _edad = edad;
        }

        public void SetContactoid(int contactoid)
        {
            _contactoid = contactoid;
        }
        public int GetContactoid()
        {
            return _contactoid;
        }

        public void SetUicacionid(int ubicacionid)
        {
            _ubicacionid = ubicacionid;
        }
        public int GetUbicacionid()
        {
            return _ubicacionid;
        }

        public void SetUsuarioid(int usuarioid)
        {
            _usuarioid = usuarioid;
        }

        public int GetUsuarioid()
        {
            return _usuarioid;
        }

        public void SetEstadoSaludid(int estadosaludid)
        {
            _estadosaludid = estadosaludid;
        }
        public int GetEstadoSaludid()
        {
            return _estadosaludid;
        }
        #endregion
    }
}
