using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BoltWPF
{
    public class Eladok
    {
        public int Azonosito { get; set; }
        public string Nev { get; set; }
        public DateTime SzuletesiIdo { get; set; }
        public string Nem { get; set; }
    }
}
