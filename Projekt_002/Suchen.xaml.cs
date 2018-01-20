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
    /// Interaktionslogik für Suchen.xaml
    /// </summary>
    public partial class Suchen : Page
    {
        private ISpielePersistenz methods; 
        public Suchen()

        {
            InitializeComponent();
            SpieleFactory fac = new SpieleFactory();
            methods = fac.GetSpielePersistenz();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                
                listSuchergebnisse.Items.Clear();
                List<Spiele> games = new List<Spiele>();
                games = methods.SpielLaden();
                

                

                String searchtext = Suchleiste.Text;

                List<Spiele> suchergebnisse = new List<Spiele>();
                //suchergebnisse.Clear();
                Spiele it = new Spiele();
                it = games.First<Spiele>();
                int sizeoflistlspiele = games.Count;
                for (int i = 0; i < sizeoflistlspiele; i++)
                {
                    it = games.ElementAt(i);
                    String name = it.Name.ToLower();
                    String sname = searchtext.ToLower();

                    if (name.Contains(sname))
                    {
                        suchergebnisse.Add(it);
                    }

                }

                listSuchergebnisse.Items.Add(suchergebnisse);
                //int sizeoflistsuchergebnisse = suchergebnisse.Count;
                //List<String> spielnamen = new List<string>();
                //for (int j = 0; j < sizeoflistsuchergebnisse; j++)
                //{
                //    it = suchergebnisse.ElementAt(j);

                //    spielnamen.Add(it.Name);
                //}
                //if(Listeboxsuche.Items.Count == 0)
                // {
                //     Listeboxsuche.ItemsSource = spielnamen;
                // }
                // else
                // {
                //     Listeboxsuche.ItemsSource = " ";
                // }


               
            }
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //Listeboxsuche.ItemsSource = 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Spiele> details = new List<Spiele>();
            details = (List<Spiele>)listSuchergebnisse.SelectedValue;
            Details windows = new Details(details);
            windows.Show();
        }

        private void listSuchergebnisse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
