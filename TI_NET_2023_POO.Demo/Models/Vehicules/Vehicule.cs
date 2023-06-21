using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TI_NET_2023_POO.Demo.Exceptions;

namespace TI_NET_2023_POO.Demo.Models.Vehicules
{
    public abstract class Vehicule
    {
        public static int _id = 1;

        private decimal _prix;

        public Vehicule(string marque, decimal prix)
        {
            Id = _id++;
            Marque = marque;
            Prix = prix;
        }

        internal int Id { get; private set; }

        public string Marque { get; set; }

        public decimal Prix
        {
            get { return _prix; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Le prix doit etre positif");
                }
                if(value == 5)
                {
                    throw new NotFiveVehiculeException();
                }
                _prix = value;
            }
        }

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
