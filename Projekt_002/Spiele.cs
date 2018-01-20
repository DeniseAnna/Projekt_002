using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt_002
{

    [Serializable]
    public class Spiele : IComparable<Spiele>
    {

        public string name;
        public string genre;
        public int bewertung;
        public bool verfuegbarkeit;
        public int usk;
        public double preis;


        public Spiele(string name, string genre, int bewertung, bool verfuegbarkeit, int usk, double preis)
        {
            this.name = name;
            this.genre = genre;
            this.bewertung = bewertung;
            this.verfuegbarkeit = verfuegbarkeit;
            this.preis = preis;
            this.usk = usk;
        }
        //defaultKonstruktor
        public Spiele() { }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String Name { get { return this.name; } set { name = value; } }
        
        public double Preis { get { return this.preis; } set { preis = value; } }

        public String Genre { get { return this.genre; } set { genre = value; } }

        public int Bewertung { get { return this.bewertung; } set { bewertung = value; } }

        public bool Verfuegbarkeit { get { return this.verfuegbarkeit; } set { verfuegbarkeit = value; } }

        public int USK { get { return this.usk; } set { usk = value; } }

        public int CompareTo(Spiele other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(Object x)
        {
            if (this == x)
                return true;
            if (x == null)
                return false;
            if (GetType() != x.GetType())
                return false;
            Spiele s = (Spiele)x;
            return name.Equals(s.name);
        }

        public override int GetHashCode()
        {
            var hashCode = -500938468;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(genre);
            hashCode = hashCode * -1521134295 + bewertung.GetHashCode();
            hashCode = hashCode * -1521134295 + verfuegbarkeit.GetHashCode();
            hashCode = hashCode * -1521134295 + usk.GetHashCode();
            hashCode = hashCode * -1521134295 + preis.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Genre);
            hashCode = hashCode * -1521134295 + Bewertung.GetHashCode();
            hashCode = hashCode * -1521134295 + Verfuegbarkeit.GetHashCode();
            hashCode = hashCode * -1521134295 + USK.GetHashCode();
            return hashCode;
        }
    }
}
