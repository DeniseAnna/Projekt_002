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
    /// Interaktionslogik für Kunden_Verwaltung.xaml
    /// </summary>
    public partial class Kunden_Verwaltung : Page
    {
        private IKundenPersistenz methods;

        public Kunden_Verwaltung()
        {
            InitializeComponent();
            KundenFactory kfac = new KundenFactory();
            methods = kfac.GetKundenPersistenz();
            List<Kunde> Kunden = new List<Kunde>();
            Kunden = methods.KundeLaden();
            Kundenlistview.ItemsSource = Kunden;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Kunde> selected = new List<Kunde>();
            // funktioniert nicht
            //selected = (List<Kunde>)Kundenlistview.SelectedValue;
            
            
            
            Kunden_Einzelverwaltung einzel = new Kunden_Einzelverwaltung(selected);
            this.NavigationService.Navigate(einzel);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Gekaufte_Spiele spiele = new Gekaufte_Spiele();
            this.NavigationService.Navigate(spiele);
        }

        private void Kundenlistview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
