using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Paciente
    {
        private int PacienteID { get; set; }
        private string PNombre { get; set; }
        private string SNombre { get; set; }
        private string PApellido { get; set; }
        private string SApellido { get; set; }
        private int Edad { get; set; }
        private string Sexo { get; set; }
        private int? ContactoID { get; set; }
        private int? UbicacionID { get; set; }
        private int UsuarioID { get; set; }
        private int? EstadoSaludID { get; set; }
        private DateTime Fecha { get; set; }


        #region acceso a las propiedades

        public void Setid(int value)
        {
            PacienteID = value;
        }

        public void SetPNombre(string pnombre)
        {
            this.PNombre = pnombre;
        }

        public void SetSNombre(string snombre)
        {
            SNombre = snombre;
        }
        public void SetPApellido(string papellido)
        {
            PApellido = papellido;
        }

        public void SetSApellido(string papellido)
        {
            SApellido = papellido;
        }

        public void SetEdad(int edad)
        {
            Edad = edad;
        }

        public void SetSexo(string sexo)
        {
            Sexo = sexo;
        }

        public void SetContactoid(int contactoid)
        {
            ContactoID = contactoid;
        }

        public void SetUicacionID(int ubicacionid)
        {
            UbicacionID = ubicacionid;
        }

        public void SetUsuarioID(int usuarioid)
        {
            UsuarioID = usuarioid;
        }

        public void SetEstadoSaludid(int estadosaludid)
        {
            EstadoSaludID = estadosaludid;
        }


        public int GetPacienteID()
        {
            return PacienteID;
        }

        public string GetPNombre()
        {
            return PNombre;
        }

        public string GetSNombre()
        {
            return SNombre;
        }

        public string GetPApellido()
        {
            return PApellido;
        }


        public string GetSApellido()
        {
            return SApellido;
        }


        public int GetEdad()
        {
            return Edad;
        }

        public string GetSexo()
        {
            return Sexo;
        }

        public int? GetContactoID()
        {
            return ContactoID;
        }

        public int? GetUbicacionID()
        {
            return UbicacionID;
        }

        public int GetUsuarioID()
        {
            return UsuarioID;
        }
        public int? GetEstadoSaludID()
        {
            return EstadoSaludID;
        }
        #endregion
    }
}
