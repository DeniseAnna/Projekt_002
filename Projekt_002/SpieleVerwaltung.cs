using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    class Spieleverwaltung : Spiele
    {
        private IDictionary<string, Spiele> spiele = new SortedList<string, Spiele>();

        private ISpielePersistenz persistenz;

        public Spieleverwaltung(string name, string genre, int bewertung, bool verfuegbarkeit, int usk, double preis) : base(name, genre, bewertung, verfuegbarkeit, usk, preis)
        {
        }

        public Spieleverwaltung() { }

        public bool Verfuegbar()
        {
            throw new NotImplementedException();
        }

        public string Nameaendern()
        {
            throw new NotImplementedException();
        }

        public string Genreaendern()
        {
            throw new NotImplementedException();
        }

        public int Bewertungaendern()
        {
            throw new NotImplementedException();
        }

        public int Uskaendern()
        {
            throw new NotImplementedException();
        }

        public double Preisaendern()
        {
            throw new NotImplementedException();
        }
    }
}
