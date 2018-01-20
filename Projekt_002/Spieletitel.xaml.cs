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
    /// Interaktionslogik für Spieletitel.xaml
    /// </summary>
    public partial class Spieletitel : Page
    {
        public Spieletitel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Warenkorb kaufen = new Warenkorb();
            this.NavigationService.Navigate(kaufen);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Spiel_bearbeiten bearbeiten = new Spiel_bearbeiten();
            this.NavigationService.Navigate(bearbeiten);
        }
    }
}
