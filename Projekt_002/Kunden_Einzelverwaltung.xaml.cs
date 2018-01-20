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
    /// Interaktionslogik für Kunden_Einzelverwaltung.xaml
    /// </summary>
    public partial class Kunden_Einzelverwaltung : Page
    {
        private IKundenPersistenz methods;

        String passwort;
       
        public Kunden_Einzelverwaltung(List<Kunde> selected)
        {
            InitializeComponent();
            Bnamebox.Text = selected.ElementAt(0).Benutzername;
            Ortbox.Text = selected.ElementAt(0).Ort;
            Straßebox.Text = selected.ElementAt(0).Strasse;
            Emailbox.Text = selected.ElementAt(0).Email;
            PLZbox.Text = selected.ElementAt(0).Plz;
            Landbox.Text = selected.ElementAt(0).Land;
            KundenFactory kfac = new KundenFactory();
            methods = kfac.GetKundenPersistenz();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            methods.UpdateKunde(Bnamebox.Text, Emailbox.Text, passwort, Straßebox.Text, PLZbox.Text, Ortbox.Text, Landbox.Text);
        }
    }
}
