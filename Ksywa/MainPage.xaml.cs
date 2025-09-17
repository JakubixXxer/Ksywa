using System.Numerics;

namespace Ksywa
{
    public partial class MainPage : ContentPage
    {
        private Random rnd = new Random();

        // Przymiotniki
        private string[][] Array1 = {
            new string[]{ "Obrzezany", "Obszczany", "Zarzygany", "Obsrany", "Czarny", "Mokry", "Spocony", "Śmierdzący" }, // Jednoosobowe męskie 
            new string[]{ "Obrzezana", "Obszczana", "Zarzygana", "Obsrana", "Czarna", "Mokra", "Spocona", "Śmierdząca" }, // Jednoosobowe żeńskie
            new string[]{ "Obrzezane", "Czyste", "Zalane", "Spocone", "Śmierdzące" }, // Jednoosobowe nijakie
            /*
            new string[]{ "" }, // Wieloosobowe męskoosobowe
            new string[]{ "Zalane" } // Wieloosobowe niemęskoosobowe i zbiorowe
            */
        };
        // Rzeczowniki
        private string[][] Array2 = { 
            new string[]{ "Napletek", "Siur", "Plemnik" }, // Jednoosobowe męskie
            new string[]{ "Dupa"}, // Jednoosobowe żeńskie
            new string[]{ "Nasienie", "Portki" }, // Jednoosobowe nijakie
            /*
            new string[]{ "" }, // Wieloosobowe męskoosobowe
            new string[]{ "" } // Wieloosobowe niemęskoosobowe i zbiorowe
            */
        };

        public MainPage()
            {
                InitializeComponent();
            }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            ushort n = (ushort)rnd.Next(0, 3);

            Nickname.Text = Array1[n][rnd.Next(Array1[n].Length)] + Array2[n][rnd.Next(Array2[n].Length)] + rnd.Next(10, 99);
        }
    }

}
