using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models.Vehicules
{
    public abstract class Vehicule
    {
        public static int _id = 1;

        public Vehicule(string marque, decimal prix)
        {
            Marque = marque;
            Prix = prix;
        }

        internal int Id { get; private set; }

        public string Marque { get; set; }

        public decimal Prix { get; set; }

        public abstract void Deplacer();


        public override string ToString()
        {
            return $"{Id} : {Marque} : {Prix}";
        }

        public static void Jammy()
        {

            Console.WriteLine("Mais qu'est ce qu'un vehicule jammy ?");

            Console.WriteLine("un vehicule mon brave ca sert a sedéplacer!");
        }
    }
}
