using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_NET_2023_POO.Exercices.Exceptions;

namespace TI_NET_2023_POO.Exercices.Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        protected Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }

        protected Compte(string numero, Personne titulaire, decimal solde) : this(numero,titulaire)
        {
            Solde = solde;
        }

        public string Numero { get; private set; }

        public decimal Solde { get; private set; }

        public Personne Titulaire { get; private set; }

        public virtual void Retrait(decimal montant)
        {
            Retrait(montant, 0);
        }

        protected void Retrait(decimal montant,decimal ligneDeCredit)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException("Montant doit etre positif");
            }
            if(Solde - montant < -ligneDeCredit)
            {
                throw new SoldeInsufisantException();
            }
            Solde -= montant;
        }

        public void Depot(decimal montant)
        {
            if (montant < 0)
            {
                throw new ArgumentOutOfRangeException("Montant doit etre positif");
            }
            Solde += montant;
        }

        protected abstract decimal CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        public static decimal operator +(Compte c1, Compte c2)
        {
            return c1.Solde + c2.Solde;
        }

        public static decimal operator +(decimal somme, Compte c)
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
