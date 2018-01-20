using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    public interface IAdminPersistenz
    {

        IDictionary<string, Kunde> KundenLadenAdmin();

        void KundeAendernAdmin(string benutzername, string email, string strasse, string plz, string ort, string land);


        List<Kunde> KundeLadenAdmin();

        List<Admin> AdminLaden();
    }
}
