using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    class AdminFactory
    {
        private AdminPersistenzEF adfac = new AdminPersistenzEF();

        public IAdminPersistenz GetAdminPersistenz()
        {
            return adfac;
        }
    }
}
