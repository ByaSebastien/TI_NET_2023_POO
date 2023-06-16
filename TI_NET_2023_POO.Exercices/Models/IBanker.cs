using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Exercices.Models
{
    public interface IBanker : ICustomer
    {
        Personne Titulaire { get; }

        string Numero { get; }

        void AppliquerInteret();
    }
}
