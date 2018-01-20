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
    /// Interaktionslogik für Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        private IKundenPersistenz methods;
        public Registration()
        {
            InitializeComponent();
            KundenFactory kfac = new KundenFactory();
            methods = kfac.GetKundenPersistenz();

        }

        //Bestätigen Button erstellen. Erst wenn dieser betätigt wird, werden die Daten gespeichert 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Kunde> customer = new List<Kunde>();
            customer = methods.KundeLaden();
            Benutzernfehler.Items.Clear();
            Passwortfehler.Items.Clear();
            Emailfehler.Items.Clear();
            String passwort1 = Passwort1.Password.ToString();
            String passwort2 = Passwort2.Password.ToString();
            if (passwort1.Equals(passwort2) == false)
            {
                String itm = "Passwort Ungleich";
                Passwortfehler.Items.Add(itm);
                return;
            }
            Kunde it = new Kunde();
            int sizeoflistcustomer = customer.Count();
            for (int i = 0; i < sizeoflistcustomer; i++)
            {
                it = customer.ElementAt(i);
                String namedb = it.benutzername;
                String nameeingabe = Benutzername.Text;

                if (namedb.Equals(nameeingabe))
                {
                    Benutzernfehler.Items.Add("bereits vergeben");
                    return;
                }
                if (Email.Text.Contains("@") == false)
                {
                    Emailfehler.Items.Add("ungültig");
                    return;
                }
                if (Benutzername.Text== String.Empty||Land.Text==String.Empty||Ort.Text==String.Empty||PLZ.Text==String.Empty||Passwort1.Password.Length==0||Strasse.Text==String.Empty)
                {
                    Emtpyfehler.Items.Add("Feld vergessen?");
                    return;
                }
    
            }
            methods.KundeErzeugen(Benutzername.Text, Email.Text, passwort1, Strasse.Text, PLZ.Text, Ort.Text, Land.Text);
        }
    }
}
