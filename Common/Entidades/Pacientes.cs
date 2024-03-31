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
        private int? _contactoid { get; set; }
        private int? _ubicacionid { get; set; }
        private int _usuarioid { get; set; }
        private int? _estadosaludid { get; set; }

        public DateTime _fecha { get; set; }

        #region acceso a las propiedades

        public void Setid(int value)
        {
            _pacienteid = value;
        }

        public void Setpnombre(string pnombre)
        {
            this._pnombre = pnombre;
        }

        public void Setsnombre(string snombre)
        {
            _snombre = snombre;
        }
        public void Setpapellido(string papellido)
        {
            _papellido = papellido;
        }

        public void Setsapellido(string papellido)
        {
            _sapellido = papellido;
        }

        public void SetContactoid(Contactos contactoid)
        {
            _contactoid = contactoid.Getcontactoid();
        }

        public void SetEdad(int edad)
        {
            _edad = edad;
        }

        public void SetUicacionid(Ubicaciones ubicacionid)
        {
            _ubicacionid = ubicacionid.Getubicacionid();
        }

        public void SetUsuarioid(Usuario usuarioid)
        {
            _usuarioid = usuarioid.GetID();
        }

        public void SetEstadoSaludid(EstadoSalud estadosaludid)
        {
            _estadosaludid = estadosaludid.GetId();
        }

        
        public int Getid()
        {
            return _pacienteid;
        }

        public string Getpnombre()
        {
            return _pnombre;
        }

        public string Getsnombre()
        {
            return _snombre;
        }

        public string Getpapellido()
        {
            return _papellido;
        }


        public string Getsapellido()
        {
            return _sapellido;
        }


        public int GetEdad()
        {
            return _edad;
        }

        public int? GetContactoid()
        {
            return _contactoid;
        }

        public int? GetUbicacionid()
        {
            return _ubicacionid;
        }

        public int GetUsuarioid()
        {
            return _usuarioid;
        }
        public int? GetEstadoSaludid()
        {
            return _estadosaludid;
        }
        #endregion
    }
}
