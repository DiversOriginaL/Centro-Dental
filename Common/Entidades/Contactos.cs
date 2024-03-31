using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Contactos
    {
        private int ContactoID { get; set; }
        private string Celular { get; set; }
        private string Telefono { get; set; }


        Paciente paciente = new Paciente();
        public void SetContactoID(int id)
        {
            paciente.SetContactoid(id);
            ContactoID = id;
        }

        public void SetCelular(string celular)
        {
            Celular = celular;
        }

        public void SetTelefono(string telefono)
        {
            Telefono = telefono;
        }


        public int GetContactoid()
        {
            return ContactoID;
        }

        public string GetCelular()
        {
            return Celular;
        }

        public string GetTelefono()
        {
            return Telefono;
        }
    }
}
