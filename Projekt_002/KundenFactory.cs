using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    class KundenFactory
    {
        private KundenPersistenzEF kfac = new KundenPersistenzEF();

        public IKundenPersistenz GetKundenPersistenz()
        {
            return kfac;
        }
    }
}
