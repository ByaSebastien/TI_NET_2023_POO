using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models.Vehicules
{
    public class Garage
    {
        public string Name { get; set; }
        public int Cote { get; set; }
        public List<Vehicule> Vehicules { get; set; }

        public Vehicule this[int  id]
        {
            get
            {
                return Vehicules.SingleOrDefault(v => v.Id == id);
            }
        }

        public Garage()
        {
            Vehicules = new List<Vehicule>();
        }

        public Garage(string name) : this()
        {
            Name = name;
        }

        public Garage(string name, int cote) : this(name)
        {
            Cote = cote;
        }

    }
}
