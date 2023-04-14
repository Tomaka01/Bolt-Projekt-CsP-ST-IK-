using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace BoltWPF
{
    public static class Adatbazis
    {
        private static string eladokFajl = "eladok.txt";
        private static string termekekFajl = "termekek.txt";

        public static void EladoHozzaadasa(Eladok elado)
        {
            string sor = $"{elado.Azonosito},{elado.Nev},{elado.SzuletesiIdo},{elado.Nem}";
            File.AppendAllText(eladokFajl, sor + Environment.NewLine);
        }

        public static List<Eladok> EladokLekerdezese()
        {
            List<Eladok> eladok = new List<Eladok>();
            string[] sorok = File.ReadAllLines(eladokFajl);

            foreach (string sor in sorok)
            {
                string[] adatok = sor.Split(',');
                int azonosito = int.Parse(adatok[0]);
                string nev = adatok[1];
                DateTime szuletesiIdo = DateTime.Parse(adatok[2]);
                string nem = adatok[3];

                Eladok elado = new Eladok()
                {
                    Azonosito = azonosito,
                    Nev = nev,
                    SzuletesiIdo = szuletesiIdo,
                    Nem = nem

                };
                eladok.Add(elado);
                return eladok;
            }
        }
}

    public static void TermekHozzaadasa(Termekek termek)
    {
        string sor = $"{termek.Azonosito},{termek.Nev},{termek.Darabszam},{termek.SzavatossagiIdo}";
        File.AppendAllText(termekekFajl, sor + Environment.NewLine);
    }

    public static List<Termekek> TermekekLekerdezese()
    {
        List<Termekek> termekek = new List<Termekek>();
        string[] sorok = File.ReadAllLines(termekekFajl);

        foreach (string sor in sorok)
        {
            string[] adatok = sor.Split(',');
            int azonosito = int.Parse(adatok[0]);
            string nev = adatok[1];
            int darabszam = int.Parse(adatok[2]);
            DateTime szavatossagiIdo = DateTime.Parse(adatok[3]);

            Termekek termek = new Termekek()
            {
                Azonosito = azonosito,
                Nev = nev,
                Darabszam = darabszam,
                SzavatossagiIdo = szavatossagiIdo
            };

            termekek.Add(termek);
        }

        return termekek;
    }
}