using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    interface IBenutzerAdmin
    {
        String Benutzernameaendern();
        String Emailaendern();
        String Adresseaendern();
        List<String> Gekauftespiele();
    }


}
