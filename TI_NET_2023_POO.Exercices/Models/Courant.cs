using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Exercices.Models
{
    public class Courant
    {
        private decimal _ligneDeCredit;

        public string Numero { get; set; }

        public decimal Solde { get; private set; }

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

        public Personne Titulaire { get; set; }

        public void Retrait(decimal montant)
        {
            if(montant < 0)
            {
                return;
            }
            if(Solde - montant < -LigneDeCredit)
            {
                return;
            }
            Solde -= montant;
        }

        public void Depot(decimal montant)
        {
            if (montant < 0)
            {
                return;
            }
            Solde += montant;
        }

        public static decimal operator + (Courant c1, Courant c2)
        {
            return c1.Solde + c2.Solde;
        }

        public static decimal operator + (decimal somme, Courant c)
        {
            //if(c.Solde > 0)
            //{
            //    return somme + c.Solde;
            //}
            //else
            //{
            //    return somme + 0;
            //}
            return somme + (c.Solde > 0 ? c.Solde : 0);
        }
    }
}
