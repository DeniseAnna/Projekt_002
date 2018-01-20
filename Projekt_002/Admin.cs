using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt_002
{
    public class Admin
    {


        public string benutzername;
        public string email;
        public string passwort;
        public string plz;
        public string ort;
        public string land;

        public Admin(String benutzername, String email, String passwort, String plz, String ort, String land)
        {
            this.benutzername = benutzername;
            this.email = email;
            this.passwort = passwort;
            this.plz = plz;
            this.ort = ort;
            this.land = land;
        }

        public Admin() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public String Benutzername { get { return this.benutzername; } set { benutzername = value; } }
        public String Email { get { return this.email; } set { email = value; } }
        public String Passwort { get { return this.passwort; } set { passwort = value; } }

        public String Plz { get { return this.plz; } set { plz = value; } }
        public String Ort { get { return this.ort; } set { ort = value; } }
        public String Land { get { return this.land; } set { land = value; } }


        public override bool Equals(Object x)
        {
            if (this == x)
                return true;
            if (x == null)
                return false;
            if (GetType() != x.GetType())
                return false;
            Admin a = (Admin)x;
            return Email.Equals(a.Email);
        }

        //muss noch implementiert werden, nur zur Vollständigkeit
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

