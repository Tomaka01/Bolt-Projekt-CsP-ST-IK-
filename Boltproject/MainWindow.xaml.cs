using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Boltproject
{
    public partial class MainWindow
    {
        private List<Termek> termekek = new List<Termek>();
        private List<Elado> eladok = new List<Elado>();
      

        public MainWindow()
        {
           
        }

        private void UjTermekFelvetele()
        {
            var termek = new Termek
            {
                Azonosito = 1,
                Nev = "Alma",
                Darabszam = 50,
                SzavatossagiIdo = DateTime.Now.AddDays(7)
            };

            termekek.Add(termek);
        }

        private void UjEladoFelvetele()
        {
            var elado = new Elado
            {
                Azonosito = 1,
                Nev = "Kovács Béla",
                SzuletesiIdo = new DateTime(1990, 1, 1),
                Nem = "férfi"
            };

            eladok.Add(elado);
        }

        private void SzavatossagiIdoLekerdezese()
        {
            foreach (var termek in termekek)
            {
                if (termek.SzavatossagVizsgalat())
                {
                    Console.WriteLine($"{termek.Nev} érvényes szavatossági idővel rendelkezik.");
                }
                else
                {
                    Console.WriteLine($"{termek.Nev} lejárt szavatossági idővel rendelkezik.");

                }
            }
        }
        private void UjTermek_Click(object sender, RoutedEventArgs e)
        {
            // Ide jön a termék felvételéhez szükséges kód, például egy új ablak megjelenítése a termék adatainak megadásával.

        }

        private void UjElado_Click(object sender, RoutedEventArgs e)
        {
            // Ide jön az eladó felvételéhez szükséges kód, például egy új ablak megjelenítése az eladó adatainak megadásával.

        }

        private void SzavatossagiIdoLekerdezese_Click(object sender, RoutedEventArgs e)
        {
            EredmenyLista.Items.Clear();

            foreach (var termek in termekek)
            {
                if (termek.SzavatossagVizsgalat())
                {
                    EredmenyLista.Items.Add($"{termek.Nev} érvényes szavatossági idővel rendelkezik.");
                }
                else
                {
                    EredmenyLista.Items.Add($"{termek.Nev} lejárt szavatossági idővel rendelkezik.");
                }
            }
        }

        private void Ertekesites_Click(object sender, RoutedEventArgs e)
        {
            // Ide jön az értékesítéshez szükséges kód, például egy új ablak megjelenítése a mennyiség és a termék azonosít

        }
    }   
}