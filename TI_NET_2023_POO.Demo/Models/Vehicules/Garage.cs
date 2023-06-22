using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models.Vehicules
{
    public delegate void NouveauVehiculeDelegate(Vehicule v);

    public class Garage
    {
        public event NouveauVehiculeDelegate NouveauVehiculeEvent;

        public string Name { get; set; }
        public int Cote { get; set; }
        public List<Vehicule> Vehicules { get; private set; }

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

        public void AjouterVehicule(Vehicule vehicule)
        {
            Vehicules.Add(vehicule);
            RaiseNouveauVehiculeEvent(vehicule);
        }

        public void NouveauVehiculeAction(Vehicule v)
        {
            Console.WriteLine(v + "est maintenant disponible");
        }

        private void RaiseNouveauVehiculeEvent(Vehicule v)
        {
            NouveauVehiculeEvent?.Invoke(v);
        }
    }
}
