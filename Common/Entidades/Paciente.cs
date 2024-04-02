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
        private string Edad { get; set; }
        private char Sexo { get; set; }
        

        public void SetPacienteID(int id)
        {
            PacienteID = id;
        }
        public void SetPNombre(string pnombre)
        {
            PNombre = pnombre;
        }
        public void SetSNombre(string snombre)
        {
            SNombre = snombre;
        }
        public void SetPApellido(string papellido)
        {
            PApellido = papellido;
        }
        public void SetSApellido(string sapellido)
        {
            SApellido = sapellido;
        }
        public void SetEdad(string edad)
        {
            Edad = edad;
        }
        public void SetSexo(char sexo)
        {
            Sexo = sexo;
        }

        public int GetPacienteID() => PacienteID;
        public string GetPNombre() => PNombre;
        public string GetSNombre() => SNombre;
        public string GetPApellido() => PApellido;
        public string GetSApellido() => SApellido;
        public string GetEdad() => Edad;
        public char GetSexo() => Sexo;

    }
}
