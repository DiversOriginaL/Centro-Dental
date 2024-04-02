using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entidades
{
    public class Ubicaciones
    {
        private int UbicacionID { get; set; }
        private string Provincia { get; set; }
        private string Sector { get; set; }
        private string Calle { get; set; }
        private string NumCasa { get; set; }

        public void SetUbicacionID(int id)
        {
            UbicacionID = id;
        }
        public void SetProvincia(string provincia)
        {
            Provincia = provincia;
        }

        public void SetSector(string sector)
        {
            Sector = sector;
        }
        public void SetCalle(string calle)
        {
            Calle = calle;
        }
        public void SetNumCasa(string numcasa)
        {
            NumCasa = numcasa;
        }

        public int GetUbicacionID() => UbicacionID;
        public string GetProvincia() => Provincia;
        public string GetSector() => Sector;
        public string GetCalle() => Calle;
        public string GetNumCasa() => NumCasa;
    }
}
