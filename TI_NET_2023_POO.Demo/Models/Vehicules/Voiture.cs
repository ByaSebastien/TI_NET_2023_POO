using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models.Vehicules
{
    public class Voiture : Vehicule
    {
        public string Couleur { get;set; }

        public override void Deplacer()
        {
            Console.WriteLine("Et je roule roule roule roule dans les rues de ma ville");
        }

        public override string ToString()
        {
            return base.ToString() + $" : {Couleur}";
        }
    }
}
