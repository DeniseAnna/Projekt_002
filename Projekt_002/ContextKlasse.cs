using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_002
{
    public class ContextKlasse : DbContext
    {
        public virtual DbSet<Kunde> Kunde { get; set; }

       public virtual DbSet<Admin> Admin { get; set; }

        public virtual DbSet<Spiele> Spiele { get; set; }

       
    }
}
