using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    public class SpieleFactory
    {
        private SpielePersistenzEF fac = new SpielePersistenzEF();

        public ISpielePersistenz GetSpielePersistenz()
        {
            return fac;
        }
    }
}
