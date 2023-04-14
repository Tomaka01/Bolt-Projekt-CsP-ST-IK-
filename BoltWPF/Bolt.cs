using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoltWPF
{
    public class Bolt
    {
        public List<Termekek> Termekek { get; set; }
        public List<Eladok> Eladok { get; set; }

        public Bolt()
        {
            Termekek = Adatbazis.TermekekLekerdezese();
            Eladok = Adatbazis.EladokLekerdezese();
        }

        public void TermekHozzaadasa(Termekek termek)
        {
            Termekek.Add(termek);
            Adatbazis.TermekHozzaadasa(termek);
        }

        public void TermekEladasa(int termekAzonosito, int darabszam)
        {
            Termekek termek = Termekek.FirstOrDefault(t => t.Azonosito == termekAzonosito);

            if (termek != null)
            {
                termek.Eladas(darabszam);
                Adatbazis.TermekekLekerdezese(Termekek);
            }
            else
            {
                throw new Exception("A termék nem található.");
            }
        }

        public void EladoHozzaadasa(Eladok elado)
        {
            Eladok.Add(elado);
            Adatbazis.EladoHozzaadasa(elado);
        }
    }
}
