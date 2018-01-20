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
    /// Interaktionslogik für Startseite_Administrator.xaml
    /// </summary>
    public partial class Startseite_Administrator : Page
    {
        private ISpielePersistenz methods;
       
     
        public Startseite_Administrator()
        {
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
            Suchen suchen = new Suchen();
            this.NavigationService.Navigate(suchen);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            Kunden_Verwaltung verwalten = new Kunden_Verwaltung();
            this.NavigationService.Navigate(verwalten);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Spieletitel_Admin bearbeiten = new Spieletitel_Admin();
            this.NavigationService.Navigate(bearbeiten);
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
