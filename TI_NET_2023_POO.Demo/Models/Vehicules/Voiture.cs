using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models.Vehicules
{
    public class Voiture : Vehicule
    {
        public Voiture(string marque, decimal prix, string couleur) : base(marque,prix)
        {
            Marque = marque;
            Prix = prix;
            Couleur = couleur;
        }
        public string Couleur { get;set; }

        public override void Deplacer()
        {
            Console.WriteLine("Et je roule roule roule roule dans les rues de ma ville");
        }

        public void Tourne()
        {
            Console.WriteLine("je tourne le volant");
        }

        public override string ToString()
        {
            return base.ToString() + $" : {Couleur}";
        }

        public static bool operator ==(Voiture a, Voiture b)
        {
            return a.Id == b.Id && a.Marque == b.Marque && a.Couleur == b.Couleur;
        }

        public static bool operator !=(Voiture a, Voiture b)
        {
            return !(a == b);
        }
    }
}
