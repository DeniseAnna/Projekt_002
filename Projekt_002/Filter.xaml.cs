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
    /// Interaktionslogik für Filter.xaml
    /// </summary>
    public partial class Filter : Page
    {
        private ISpielePersistenz methods;
        public Filter()
        {
            InitializeComponent();
            initcomboboxgenre();
            Initcomboboxbewertung();
            SpieleFactory fac = new SpieleFactory();
            methods = fac.GetSpielePersistenz();
        }
        private void initcomboboxgenre()
        {
            List<string> data = new List<string>();
            data.Add("rpg");
            data.Add("Horror");
            data.Add("visual novel");
            data.Add("shooter");
            data.Add("strategie");
            data.Add("racing");
            data.Add("kein Filter");

            Genre.ItemsSource = data;
        }
        private void Initcomboboxbewertung()
        {
            List<String> data = new List<String>();
            data.Add("1");
            data.Add("2");
            data.Add("3");
            data.Add("4");
            data.Add("5");
            data.Add("6");
            data.Add("7");
            data.Add("8");
            data.Add("9");
            data.Add("10");
            data.Add("kein Filter");

            Bewertung.ItemsSource = data;

        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gefiltert.Items.Clear();
            List<Spiele> lspiele = new List<Spiele>();
            lspiele = methods.SpielLaden();
            
            List<Spiele> nachbewertung = new List<Spiele>();
            nachbewertung.Clear();
           
            int sizeoflistlspiele = lspiele.Count;
            Spiele it = new Spiele();
            List<Spiele> nachgenre = new List<Spiele>();
            nachgenre.Clear();
            if (Genre.SelectedIndex != -1 && Genre.SelectedIndex!=6 )
            {

                for (int i = 0; i < sizeoflistlspiele; i++)
                {
                    it = lspiele.ElementAt(i);
                    if (Genre.SelectedIndex == 0)
                    {
                        if (it.genre == "rpg")
                        {
                            nachgenre.Add(it);
                        }
                    }
                    else if (Genre.SelectedIndex == 1)
                    {
                        if (it.genre == "Horror")
                        {
                            nachgenre.Add(it);
                        }
                    }
                    else if (Genre.SelectedIndex == 2)
                    {
                        if (it.genre == "visual novel")
                        {
                            nachgenre.Add(it);
                        }
                    }
                    else if (Genre.SelectedIndex == 3)
                    {
                        if (it.genre == "shooter")
                        {
                            nachgenre.Add(it);
                        }
                    }
                    else if (Genre.SelectedIndex == 4)
                    {
                        if (it.genre == "strategie")
                        {
                            nachgenre.Add(it);
                        }
                    }
                    else if (Genre.SelectedIndex == 5)
                    {
                        if (it.genre == "racing")
                        {
                            nachgenre.Add(it);
                        }
                    }
                }
            }
            else
            {
                int lspielecounter = lspiele.Count();
                for (int i = 0; i < lspielecounter; i++)
                {
                    nachgenre.Add(lspiele.ElementAt(i));
                }
            }
            
            if (Bewertung.SelectedIndex != -1 && Bewertung.SelectedIndex != 10)
            {
                int sizeoflistnachgenre = nachgenre.Count;
                if (Bewertung.SelectedIndex == 0)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 1)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                if (Bewertung.SelectedIndex == 1)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 2)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                if (Bewertung.SelectedIndex == 2)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 3)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                if (Bewertung.SelectedIndex == 3)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 4)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                if (Bewertung.SelectedIndex == 4)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 5)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                if (Bewertung.SelectedIndex == 5)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 6)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                if (Bewertung.SelectedIndex == 6)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 7)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                if (Bewertung.SelectedIndex == 7)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 8)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                if (Bewertung.SelectedIndex == 8)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 9)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                if (Bewertung.SelectedIndex == 9)
                {
                    Spiele it0 = new Spiele();
                    for (int i = 0; i < sizeoflistnachgenre; i++)
                    {
                        it0 = nachgenre.ElementAt(i);
                        if (it0.bewertung == 10)
                        {
                            nachbewertung.Add(it);
                        }
                    }

                }
                

            }
            else
            {
                nachbewertung = nachgenre;
            }
            List<Spiele> listgefiltert = new List<Spiele>();
            int nachgenrecounter=nachgenre.Count();
            int nachbewertungcounter = nachbewertung.Count();
          for (int i=0; i<nachgenrecounter; i++)
            {
                for (int j = 0; j < nachbewertungcounter; j++)
                {
                    String s1=nachgenre.ElementAt(i).Name;
                    String s2 = nachbewertung.ElementAt(j).Name;
                    if (s1.Equals(s2))
                    {
                        listgefiltert.Add(nachgenre.ElementAt(i));
                    }
                }
            }
            gefiltert.Items.Add(nachbewertung);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}


