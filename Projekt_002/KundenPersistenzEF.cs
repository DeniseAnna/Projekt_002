using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Projekt_002
{
    public class KundenPersistenzEF : IKundenPersistenz
    {
 
        public void KundeErzeugen(string benutzername, string email, string passwort, string strasse, string plz, string ort, string land)
        {
            using (ContextKlasse db = new ContextKlasse())
            {
                try
                {
                    Kunde kunde = new Kunde(benutzername, email, passwort, strasse, plz, ort, land); // aufruf 2. Konstruktor
                    db.Kunde.Add(kunde);
                    db.SaveChanges();
                } catch (Exception e)
                {
                    return;
                }
            }
        }

        public IDictionary<string, Kunde> loadDatabase()
        {

            IDictionary<string, Kunde> kunden = new SortedList<string, Kunde>();
            using (ContextKlasse db = new ContextKlasse())
            {
                //Erster Kunde von dem aus durchiteriert wird
                IEnumerable<Kunde> kunde1 = db.Kunde
                                      //.Include(b => b.authors)  // oder Include("Authors")
                                      .ToList();

                //Datenbank durchgehen und jeden Kunden in die Liste hinzufügen
                foreach (Kunde k in kunde1)
                {
                    kunden.Add(k.benutzername, k);
               
                }
            }
            return kunden;
        }

        //kann evtl wieder rausgelöscht werden, war nur zum Listen ausprinten
        public static void printList(IDictionary<string, Kunde> liste)
        {
            IEnumerable<Kunde> kunde1 = (IEnumerable<Kunde>)liste.GetEnumerator();
            foreach (Kunde k in kunde1)
            {
                Console.WriteLine("Benutzername: " + k.benutzername);
            }



        }


        public void UpdateKunde(string benutzername, string neueEmail, string neuespasswort, string neuestrasse, string neueplz, string neuerort, string neuesland)
        {
            using (var con = new ContextKlasse())
            {
                var kunde = con.Kunde.Find(benutzername);
                if(kunde == null)               
                    return;

                    kunde.email     = neueEmail;
                    kunde.passwort  = neuespasswort;
                    kunde.strasse   = neuestrasse;
                    kunde.plz       = neueplz;
                    kunde.ort       = neuerort;
                    kunde.land      = neuesland;
                    con.SaveChanges();
                    
                
            }
        }

        public List<Kunde> KundeLaden()
        {
            List<Kunde> kunden = new List<Kunde>();
            using (ContextKlasse db = new ContextKlasse())
            {
                // gibt Fehler bei bestimmten Buttons
                kunden = db.Kunde.ToList();

            }
            return kunden;
        }





        /*
        // Kunde mit Key benutzername:String, als eindeutig.
        public IDictionary<string, Kunde> KundeLaden()
        {
            IDictionary<string, Kunde> kunde = new SortedList<string, Kunde>();
            using (ContextKlasse db = new ContextKlasse())
            {

                IEnumerable<Kunde> kunde1 = db.Kunde;
                //.Include(k=> k.au..)  // oder Include("Authors") ?
                //.ToList(); ?
                foreach (Kunde k in kunde1)
                {
                    kunde.Add(k.benutzername, k);
                }
            }
            return kunde;
        } 
            public void KundeSpeichern(IDictionary<string, Kunde> kundenDi)
            {
                using (ContextKlasse db = new ContextKlasse())
                {
                    // alle Kunden aus dem Dictionary abspeichern die noch nicht in der DB stehen
                    foreach (KeyValuePair<string, Kunde> entry in kundenDi)   /// ??????
                    {
                        // Check for duplicates.            
                        Kunde k = db.Kunde.Find(entry.Value.benutzername);
                        if (k == null)
                        {
                            // Add the new kunde.      
                            db.Kunde.Add(entry.Value);
                        }

                    }
                    db.SaveChanges();

                    // alle Kunden löschen die in DB stehen aber nicht im Dictionary
                    IQueryable<Kunde> kundeQuery = from k in db.Kunde
                                                   orderby k.benutzername
                                                   select k;
                    if (kundeQuery.Count() > 0)
                        foreach (Kunde kunde in kundeQuery)
                        {
                            if (!kundenDi.ContainsKey(kunde.benutzername))
                            {
                                // Buch löschen
                                db.Kunde.Remove(kunde);
                            }
                        }
                    db.SaveChanges();
                }
            } 
        } */
    }
}






