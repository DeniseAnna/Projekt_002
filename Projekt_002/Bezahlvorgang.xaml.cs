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
    /// Interaktionslogik für Bezahlvorgang.xaml
    /// </summary>
    public partial class Bezahlvorgang : Page
    {
        public Bezahlvorgang()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Key_Ausgabe ausgabe = new Key_Ausgabe();
            this.NavigationService.Navigate(ausgabe);
        }
    }
}
