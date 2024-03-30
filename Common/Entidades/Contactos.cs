using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Contactos
    {
        private int _contactoid { get; set; }
        private string _celular { get; set; }
        private string _telefono { get; set; }

        public void Setcontactoid(int id)
        {
            _contactoid = id;
        }

        public void Setcelular(string celular)
        {
            _celular = celular;
        }

        public void Settelefono(string telefono)
        {
            _telefono = telefono;
        }


        public int Getcontactoid()
        {
            return _contactoid;
        }

        public string Getcelular()
        {
            return _celular;
        }

        public string Gettelefono()
        {
            return _telefono;
        }
    }
}
