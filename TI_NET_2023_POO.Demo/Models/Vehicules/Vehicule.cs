using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models.Vehicules
{
    public class Vehicule
    {
        public string Marque { get; set; }

        public decimal Prix { get; set; }

        public virtual void Deplacer()
        {
            Console.WriteLine("Le vehicule se deplace");
        }

        public override string ToString()
        {
            return $"{Marque} : {Prix}";
        }
    }
}
