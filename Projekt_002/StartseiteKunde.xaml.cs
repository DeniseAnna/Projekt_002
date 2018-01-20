using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt_002
{
    /// <summary>
    /// Interaktionslogik für Startseite_Kunde.xaml
    /// </summary>
    public partial class Startseite_Kunde : Page
    {
        private Kunde currentUser;
        //List<Kunde> eingeloggt = new List<Kunde>();
        //public Startseite_Kunde(List<Kunde> eingeloggt)
        //{
        //    this.eingeloggt = eingeloggt;
        //}
        private ISpielePersistenz methods;
        public Startseite_Kunde(Kunde user)
        {
            currentUser = user;
            InitializeComponent();
            SpieleFactory fac = new SpieleFactory();
            methods = fac.GetSpielePersistenz();
            List<Spiele> games = new List<Spiele>();
            games = methods.SpielLaden();
            
            AlleSpiele.ItemsSource = games;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Warenkorb bezahlen = new Warenkorb();
            this.NavigationService.Navigate(bezahlen);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Benutzerverwaltung verwalten = new Benutzerverwaltung(currentUser);
   
            this.NavigationService.Navigate(verwalten);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Gekaufte_Spiele spiele = new Gekaufte_Spiele();
            this.NavigationService.Navigate(spiele);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Suchen suchen = new Suchen();
            this.NavigationService.Navigate(suchen);
        }

      

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Filter filter = new Filter();
            this.NavigationService.Navigate(filter);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
