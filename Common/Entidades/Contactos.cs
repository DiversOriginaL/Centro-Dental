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

        public void SetContactoID(int id)
        {
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

        public int GetContactoID() => ContactoID;
        public string GetCelular() => Celular;
        public string GetTelefono() => Telefono;
    }
}
