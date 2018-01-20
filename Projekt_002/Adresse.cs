using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    [Serializable]
    public class Adresse 
    {
        public string benutzername;
        public String strasse;
        public String plz;
        public String ort;
        public String land;

        public Adresse(string benutzername, String strasse, String plz, String ort, String land)
        {
            this.benutzername = benutzername;
            this.strasse = strasse;
            this.plz = plz;
            this.ort = ort;
            this.land = land;
        }

        public String Benutzername { get { return this.benutzername; } set { benutzername = value; } }
        public String Plz { get { return this.plz; } set { plz = value; } }
        public String Ort { get { return this.ort; } set { ort = value; } }
        public String Land { get { return this.land; } set { land = value; } }
 

        public override bool Equals(Object x)
        {
            if (this == x)
                return true;
            if (x == null)
                return false;
            if (GetType() != x.GetType())
                return false;

            Adresse adresse = (Adresse)x;

            if (!land.Equals(adresse.land))
                return false;
            if (!ort.Equals(adresse.ort))
                return false;
            if (!plz.Equals(adresse.plz))
                return false;
            if (!strasse.Equals(adresse.strasse))
                return false;

            return true;
        }
        public override int GetHashCode()
        {
            int result;
            result = strasse.GetHashCode();
            result = 29 * result + plz.GetHashCode();
            result = 29 * result + ort.GetHashCode();
            result = 29 * result + land.GetHashCode();
            return result;
        }
        public override String ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(strasse);
            result.Append("\n" + land + " " + plz + " " + ort);
            return result.ToString();
        }
    }
}
