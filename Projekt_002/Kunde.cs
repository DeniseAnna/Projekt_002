using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt_002
{
    [Serializable]
    public class Kunde : IComparable<Kunde>
    {

        public string benutzername;
        public string email;
        public string passwort;
        public string strasse;
        //public Adresse adresse;
        public string plz;
        public string ort;
        public string land;

        public Kunde(string benutzername, string email, string passwort, string strasse, string plz, string ort, string land)
        {

            this.benutzername = benutzername;
            this.email = email;
            this.passwort = passwort;
            this.strasse = strasse;
            this.plz = plz;
            this.ort = ort;
            this.land = land;

        }
        //Default Konstruktor
        public Kunde() { }

        //public Kunden(string benutzername, string email, string passwort, Adresse adresse, List<Spiele> gekaufteSpiele)
        //{
        //    this.benutzername = benutzername;
        //    this.email = email;
        //    this.passwort = passwort;
        //this.adresse = adresse;
        //this.gekaufteSpiele = gekaufteSpiele; //Liste von gekauften Spielen

        //}
        //später hinzufügen: Spiele auch aus Kundenliste entfernen lassen


        //public Kunden(string benutzername, string email, string passwort, Adresse adresse) //für KundeErzeugen
        //{
        //    try
        //    {
        //        this.benutzername = benutzername;
        //        this.email = email;
        //        this.passwort = passwort;
        //        this.adresse = adresse;
        //    }
        //    catch (Exception e)
        //    {
        //        return;
        //    }

        //}


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public String Benutzername { get { return this.benutzername; } set { benutzername = value; } }

        public String Email { get { return this.email; } set { email = value; } }
        public String Passwort { get { return this.passwort; } set { passwort = value; } }
        public String Strasse { get { return this.strasse; } set { strasse = value; } }
        //public Adresse Adresse { get { return this.adresse; } set { adresse = value; } }
        public String Plz { get { return this.plz; } set { plz = value; } }
        public String Ort { get { return this.ort; } set { ort = value; } }
        public String Land { get { return this.land; } set { land = value; } }
        //public Adresse adresse { get { return this.adresse; } set { adresse = value; } }
        //List<Spiele> gekaufteSpiele;





        public override bool Equals(Object x)
        {

            if (this == x)
                return true;
            if (x == null)
                return false;
            if (GetType() != x.GetType())
                return false;

            Kunde kunde = (Kunde)x;

            if (!benutzername.Equals(kunde.benutzername))
                return false;
            if (!email.Equals(kunde.email))
                return false;
            if (!passwort.Equals(kunde.passwort))
                return false;
            if (!strasse.Equals(kunde.strasse))
                return false;
            if (!plz.Equals(kunde.plz))
                return false;
            if (!ort.Equals(kunde.ort))
                return false;
            if (!land.Equals(kunde.land))
                return false;

            return true;
        }

        public override int GetHashCode()
        {
            int result;
            result = benutzername.GetHashCode();
            result = 29 * result + email.GetHashCode();
            result = 29 * result + passwort.GetHashCode();
            result = 29 * result + strasse.GetHashCode();
            result = 29 * result + plz.GetHashCode();
            result = 29 * result + ort.GetHashCode();
            result = 29 * result + land.GetHashCode();
            return result;
        }


        //muss noch implementiert werden
        public int CompareTo(Kunde other)
        {
            throw new NotImplementedException();
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(benutzername);
            result.Append("\n" + email + " " + passwort + " " + strasse + " " + plz + " " + ort + " " + land);
            return result.ToString();
        }
    }


}
