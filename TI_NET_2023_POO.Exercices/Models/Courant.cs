using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Exercices.Models
{
    public class Courant : Compte
    {
        private decimal _ligneDeCredit;

        public decimal LigneDeCredit
        {
            get 
            {
                return _ligneDeCredit; 
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _ligneDeCredit = value;
            }
        }

        public override void Retrait(decimal montant)
        {
            Retrait(montant,LigneDeCredit);
        }
    }
}
