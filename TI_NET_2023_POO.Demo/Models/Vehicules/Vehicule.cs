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

        public Vehicule()
        {
            Id = _id++;
        }

        public int Id { get; set; }

        public string Marque { get; set; }

        public decimal Prix { get; set; }

        public abstract void Deplacer();


        public override string ToString()
        {
            return $"{Id} : {Marque} : {Prix}";
        }
    }
}
