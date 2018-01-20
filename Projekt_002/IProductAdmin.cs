using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    interface IProductAdmin
    {

        String NameAendern();

        String GenreAendern();

        int BewertungAendern();

        bool VerfügbarkeitAendern();

        int USKAendern();

        double PreisAendern();

        List<String> Spiele();

    }
}
