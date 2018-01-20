using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    class KundenVerwaltung : Kunde
    {
        private IDictionary<string, Kunde> kunden = new SortedList<string, Kunde>();

      
        
        private IKundenPersistenz persistenz;

        /// <summary>
        /// Kundenverwaltung wird mit der Persistenz-Implementierung von außen versorgt
        /// </summary>
        /*public KundenVerwaltung(IKundenPersistenz persistenz)
        {
            this.persistenz = persistenz;
            kunden = persistenz.KundeLaden();  // Laden der Daten 
        }*/

        public void KundeHinzufügenD (Kunde kunde, string s)
        {
            
            kunden.Add(s, kunde);

        }

        
     

    }
}
