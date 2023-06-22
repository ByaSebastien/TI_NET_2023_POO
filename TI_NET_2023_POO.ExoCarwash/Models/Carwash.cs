using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.ExoCarwash.Models
{
    public delegate void CarwashDelegate(Voiture v);
    public class Carwash
    {
        public CarwashDelegate CarwashDelegate;

        public Carwash()
        {
            CarwashDelegate = (Voiture v) => Console.WriteLine($"Je prepare la voiture {v.Plaque}");
            CarwashDelegate += (Voiture v) => Console.WriteLine($"Je lave la voiture {v.Plaque}");
            CarwashDelegate += (Voiture v) => Console.WriteLine($"Je seche la voiture {v.Plaque}");
            CarwashDelegate += (Voiture v) => Console.WriteLine($"Je finalise la voiture {v.Plaque}");
        }

        private void Preparer(Voiture v)
        {
            Console.WriteLine($"Je prepare la voiture {v.Plaque}");
        }

        private void Laver(Voiture v)
        {
            Console.WriteLine($"Je lave la voiture {v.Plaque}");
        }

        private void Secher(Voiture v)
        {
            Console.WriteLine($"Je seche la voiture {v.Plaque}");
        }
        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"Je finalise la voiture {v.Plaque}");
        }

        public void Traiter(Voiture v)
        {
            //Preparer(v);
            //Laver(v);
            //Secher(v);
            //Finaliser(v)

            CarwashDelegate?.Invoke(v);
        }
    }
}
