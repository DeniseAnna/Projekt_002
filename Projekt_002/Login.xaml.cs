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
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Page
    {

        Kunde eingeloggt = new Kunde();
        private IKundenPersistenz methods;
        private IAdminPersistenz methodsa;
        public Login()
        {
           
            InitializeComponent();
            KundenFactory kfac = new KundenFactory();
            methods = kfac.GetKundenPersistenz();
            AdminFactory afac = new AdminFactory();
            methodsa = afac.GetAdminPersistenz();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            fehler.Items.Clear();
            List<Kunde> customer = new List<Kunde>();
            customer = methods.KundeLaden();
            List<Admin> admins = new List<Admin>();
            admins = methodsa.AdminLaden();
            Kunde it = new Kunde();
            int counter = 0;
            String passwort = PBox.Password.ToString();
            int sizeoflistcustomer = customer.Count();
            int sizeoflistadmin = admins.Count();
            Admin ait = new Admin();
            for (int a = 0; a < sizeoflistadmin; a++)
            {
                ait = admins.ElementAt(a);
                if (Bname.Text.Equals(ait.benutzername))
                {
                    if (passwort.Equals(ait.passwort))
                    {
                        Startseite_Administrator a1 = new Startseite_Administrator();
                        this.NavigationService.Navigate(a1);
                    }
                }
            }
            
            for (int i = 0; i < sizeoflistcustomer; i++)
            {
                it = customer.ElementAt(i);
                if (it.Benutzername.Equals(Bname.Text))
                {
                    if (passwort == it.Passwort)
                    {
                       
                        eingeloggt = it;
                        List<Kunde> eingeloggtl=new List<Kunde>();
                        eingeloggtl.Add(eingeloggt);
                        Startseite_Kunde k1 = new Startseite_Kunde(eingeloggt);
                        this.NavigationService.Navigate(k1);
                    }
                    else
                    {
                        if (counter == 0)
                        {
                            fehler.Items.Add("Ungültige Kombination");
                            counter++;
                        }
                    }
                }
                else
                {
                    if (counter == 0)
                    {
                        fehler.Items.Add("Ungültige Kombination");
                        counter++;
                    }
                }
                
               
            }
        }

        public Kunde GeteingeloggterKunde()
        {
            return eingeloggt;
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration registrieren = new Registration();
            this.NavigationService.Navigate(registrieren);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Startseite_Administrator admin = new Startseite_Administrator();
            this.NavigationService.Navigate(admin);
        }
    }
}
