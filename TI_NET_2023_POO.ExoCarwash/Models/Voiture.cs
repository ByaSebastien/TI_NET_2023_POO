using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.ExoCarwash.Models
{
    public class Voiture
    {
        public Voiture(string plaque)
        {
            Plaque = plaque;
        }

        public string Plaque { get; set; }
    }
}
