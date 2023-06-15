using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models.Vehicules
{
    public class Avion : Vehicule
    {
        public int Speed { get; set; }

        public override void Deplacer()
        {
            Console.WriteLine("Sous le vent....");
        }
        public override string ToString()
        {
            return base.ToString() + $" : {Speed}";
        }

    }
}
