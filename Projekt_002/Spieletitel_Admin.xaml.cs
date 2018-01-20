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
    /// Interaktionslogik für Spieletitel_Admin.xaml
    /// </summary>
    public partial class Spieletitel_Admin : UserControl
    {
        private ISpielePersistenz methods;
        public Spieletitel_Admin()
        {
            InitializeComponent();
            SpieleFactory sfac = new SpieleFactory();
            methods = sfac.GetSpielePersistenz();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Spiele> games = new List<Spiele>();
            games = methods.SpielLaden();
            if (SpieleName.Text == String.Empty || Genrebox.Text == String.Empty || Bewertungbox.Text == String.Empty || USKbox.Text == String.Empty || SpielePreis.Text == String.Empty)
            {
                Emtpyfehler.Items.Add("Feld vergessen?");
                return;
            }
            if (!SpielePreis.Text.Contains(","))
            {
                preisfehler.Items.Add("Komma benötigt");
                return;
            }
            int bewertung = Int32.Parse(Bewertungbox.Text);
            int usk = Int32.Parse(USKbox.Text);
            double preis = double.Parse(SpielePreis.Text);
            methods.SpielErzeugen(SpieleName.Text, Genrebox.Text, bewertung, true, usk, preis);
        }
    }
}
