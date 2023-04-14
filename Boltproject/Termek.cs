using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Boltproject
{
    public class Termek
    {
        public int Azonosito { get; set; }
        public string Nev { get; set; }
        public int Darabszam { get; set; }
        public DateTime SzavatossagiIdo { get; set; }

        public bool SzavatossagVizsgalat()
        {
            return DateTime.Now <= SzavatossagiIdo;
        }

        public void Ertekesites(int mennyiseg)
        {
            Darabszam -= mennyiseg;
        }
    }
}
