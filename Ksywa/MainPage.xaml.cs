using System.Numerics;

namespace Ksywa
{
    public partial class MainPage : ContentPage
    {
        private Random rnd = new Random();

        // Przymiotniki
        private string[][] Array1 = {
            new string[]{ "Obrzezany", "Obszczany", "Zarzygany", "Obsrany", "Czarny", "Mokry", "Spocony", "Śmierdzący", "Zaszczany", "Wyruchany", "Naćpany", "Tajemniczy", "Owłosiony", "Czysty", "Zalany" }, // Jednoosobowe męskie
            new string[]{ "Obrzezana", "Obszczana", "Zarzygana", "Obsrana", "Czarna", "Mokra", "Spocona", "Śmierdząca", "Zaszczana", "Wyruchane", "Naćpana", "Tajemnicza", "Owłosiona", "Czysta", "Zalana" }, // Jednoosobowe żeńskie
            new string[]{ "Obrzezane", "Obszczane", "Zarzygane", "Obsrane", "Czarne", "Mokre", "Spocone", "Śmierdzące", "Zaszczane", "Wyruchane", "Naćpane", "Tajemnicze", "Owłosione", "Czyste", "Zalane" }, // Jednoosobowe nijakie
            /*
            new string[]{ "" }, // Wieloosobowe męskoosobowe
            new string[]{ "Zalane" } // Wieloosobowe niemęskoosobowe i zbiorowe
            */
        };
        // Rzeczowniki
        private string[][] Array2 = { 
            new string[]{ "Napletek", "Siur", "Plemnik", "Kondom", "Odbyt", "Ogór", "Fiut" }, // Jednoosobowe męskie
            new string[]{ "Dupa", "Skórka", "Knaga", "Stulejka" }, // Jednoosobowe żeńskie
            new string[]{ "Nasienie", "Portki", "Jajo", "Jądro", "Łoniaki", "Cyce" }, // Jednoosobowe nijakie
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

            if(RadioMale.IsChecked) n = 0;
            else if (RadioFemale.IsChecked) n = 1;
            else if (RadioNeutral.IsChecked) n = 2;

            Nickname.Text = Array1[n][rnd.Next(Array1[n].Length)] + Array2[n][rnd.Next(Array2[n].Length)] + rnd.Next(10, 99);
        }
    }

}
