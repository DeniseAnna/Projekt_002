using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    public interface IKundenPersistenz
    {

       

        IDictionary<string, Kunde> loadDatabase();

        //void KundeSpeichern(IDictionary<string, Kunde> di);

        void UpdateKunde(string benutzername, string email, string passwort, string strasse, string plz, string ort, string land);


        //void KundeAendern(Kunde kunde, string benutzername, string email, string passwort, string strasse, string plz, string ort, string land);


        void KundeErzeugen(string benutzername, string email, string passwort, string strasse, string plz, string ort, string land);

        List<Kunde> KundeLaden();
    }
}




