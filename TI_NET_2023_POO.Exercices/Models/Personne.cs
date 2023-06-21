using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Exercices.Models
{
    public class Personne
    {
        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaiss = dateNaiss;
        }

        public string Nom { get; private set; }

        public string Prenom { get; private set; }

        public DateTime DateNaiss { get; private set; }

        public static bool operator ==(Personne p1, Personne p2)
        {
            return p1.Nom == p2.Nom && p1.Prenom == p2.Prenom && p1.DateNaiss == p2.DateNaiss;
        }

        public static bool operator !=(Personne p1, Personne p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object personne)
        {
            if (personne == null)
                return false;

            return this == (Personne)personne;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Nom != null ? Nom.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Prenom != null ? Prenom.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ DateNaiss.GetHashCode();
                return hashCode;
            }
        }
    }
}
