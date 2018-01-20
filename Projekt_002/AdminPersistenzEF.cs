using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    class AdminPersistenzEF : IAdminPersistenz
    {
        public List<Admin> AdminLaden()
        {
            List<Admin> admin = new List<Admin>();
            using (ContextKlasse db = new ContextKlasse())
            {
                admin = db.Admin.ToList();

            }
            return admin;
        }

        //KundeAendernAdmin ohne Passwortaenderung
        public void KundeAendernAdmin(string benutzername, string neueEmail, string neueStrasse, string neuePlz, string neuerOrt, string neuesLand)
        {
            using (var con = new ContextKlasse())
            {
                var kunde = con.Kunde.Find(benutzername);
                if (kunde == null)
                    return;

                kunde.email = neueEmail;
                kunde.strasse = neueStrasse;
                kunde.plz = neuePlz;
                kunde.ort = neuerOrt;
                kunde.land = neuesLand;
                con.SaveChanges();


            }
        }

        public List<Kunde> KundeLadenAdmin()
        {
            List<Kunde> kunden = new List<Kunde>();
            using (ContextKlasse db = new ContextKlasse())
            {
                kunden = db.Kunde.ToList();

            }
            return kunden;
        }

        public IDictionary<string, Kunde> KundenLadenAdmin()
        {
            IDictionary<string, Kunde> kunden = new SortedList<string, Kunde>();
            using (ContextKlasse db = new ContextKlasse())
            {
                //Erster Kunde von dem aus durchiteriert wird
                IEnumerable<Kunde> kunde1 = db.Kunde
                                      .ToList();

                //Datenbank durchgehen und jeden Kunden in die Liste hinzufügen
                foreach (Kunde k in kunde1)
                {
                    kunden.Add(k.benutzername, k);
                }
            }
            return kunden;
        }
    }
}



