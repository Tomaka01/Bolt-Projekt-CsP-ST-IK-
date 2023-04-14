using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BoltWPF
{
    public class Termekek
    {
        public int Azonosito { get; set; }
        public string Nev { get; set; }
        public int Darabszam { get; set; }
        public DateTime SzavatossagiIdo { get; set; }

        public bool LejartSzavatossagu
        {
            get
            {
                return SzavatossagiIdo < DateTime.Now;
            }
        }

        public void Eladas(int darabszam)
        {
            if (Darabszam >= darabszam)
            {
                Darabszam -= darabszam;
            }
            else
            {
                throw new Exception("Nincs elegendő darabszám.");
            }
        }
    }
}
