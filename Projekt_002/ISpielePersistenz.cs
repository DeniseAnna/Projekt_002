using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    public interface ISpielePersistenz
    {
        List<Spiele> SpielLaden();

        void SpielSpeichern(IDictionary<string, Spiele> NeuesSpiel);


        void SpielAendern(string name, string genre, int bewertung, bool verfuegbarkeit, int usk, double preis);


        void SpielErzeugen(string name, string genre, int bewertung, bool verfuegbarkeit, int usk, double preis);

       



    }
}
