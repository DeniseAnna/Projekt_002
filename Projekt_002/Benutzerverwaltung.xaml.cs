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
    /// Interaktionslogik für Benutzerverwaltung.xaml
    /// </summary>
    public partial class Benutzerverwaltung : Page
    {
        private IKundenPersistenz methods;

        String benName;
        private Kunde currentUser;
        //List<Kunde> eingeloggt = new List<Kunde>();
        public Benutzerverwaltung (Kunde user)
        {
            KundenFactory kfac = new KundenFactory();
            methods = kfac.GetKundenPersistenz();

            currentUser = user;
            InitializeComponent();
            
            this.Emailbox.Text =  currentUser.email;
            this.PasswortBox.Text = currentUser.passwort;
            this.LandBox.Text = currentUser.land;
            this.PlzBox.Text = currentUser.plz;
            this.OrtBox.Text = currentUser.ort;
            this.Straßenbox.Text = currentUser.strasse;

            this.benName = currentUser.benutzername;

        }

        public Kunde getCurrentUser()
        {
            return currentUser;
        }

        
        
        
   
        public Benutzerverwaltung()
        {

            InitializeComponent();
  
         
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            methods.UpdateKunde(benName, Emailbox.Text, PasswortBox.Text, Straßenbox.Text, PlzBox.Text, OrtBox.Text, LandBox.Text);
            

        }
    }
}
