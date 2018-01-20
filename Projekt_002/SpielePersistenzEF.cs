using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    class SpielePersistenzEF : ISpielePersistenz
    {
        //ok
        public void SpielAendern(string name, string neuesgenre, int neuebewertung, bool neueverfuegbarkeit, int neuerusk, double neuerpreis)
        {
            using (var con = new ContextKlasse())
            {
                var spiele = con.Spiele.Find(name);
                if (spiele == null)
                    return;

                spiele.genre            = neuesgenre;
                spiele.bewertung        = neuebewertung;
                spiele.verfuegbarkeit   = neueverfuegbarkeit;
                spiele.usk              = neuerusk;
                spiele.preis            = neuerpreis;
                con.SaveChanges();


            }
        }

        //ok
        public void SpielErzeugen(string name, string genre, int bewertung, bool verfuegbarkeit, int usk, double preis)
        {
            using (ContextKlasse db = new ContextKlasse())
            {
                try
                {
                    Spiele spiele = new Spiele(name, genre, bewertung, verfuegbarkeit, usk, preis); 
                    db.Spiele.Add(spiele);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    return;
                }
            }
        }

        //ok
        public List<Spiele> SpielLaden()
        {
            List<Spiele> spiele = new List<Spiele>();
            using (ContextKlasse db = new ContextKlasse())
            {
                //Erstes Spiel von dem aus durchiteriert wird


                spiele = db.Spiele.ToList();
                
                //Datenbank durchgehen und jedes Spiel in die Liste hinzufügen
               
            }
            return spiele;
        }

        public List<Spiele> Spieleladelist()
        {
            List<Spiele> s1 = new List<Spiele>();
            using (ContextKlasse db = new ContextKlasse())
            {
                IEnumerable<Spiele> spiele1 = db.Spiele.ToList();
                                      

                foreach (Spiele k in spiele1)
                {
                    s1.Add(k);

                }

            }
            return s1;
        }

        public void SpielSpeichern(IDictionary<string, Spiele> NeuesSpiel)
        {
            throw new NotImplementedException();
        }
    }
}
