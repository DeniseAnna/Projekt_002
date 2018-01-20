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
using System.Windows.Shapes;

namespace Projekt_002
{
    /// <summary>
    /// Interaktionslogik für Details.xaml
    /// </summary>
    public partial class Details : Window
    {
        public Details(List<Spiele> spiele)
        {
            InitializeComponent();
            foreach(var item in spiele) { 
            NameBox.Text = item.Name;
            }
        }

        private void bla_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
