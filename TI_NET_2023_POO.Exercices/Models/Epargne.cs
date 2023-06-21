using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Exercices.Models
{
    public class Epargne : Compte
    {
        public Epargne(string numero, Personne titulaire) : base(numero, titulaire) { }
        public Epargne(string numero, Personne titulaire, decimal solde) : base(numero, titulaire, solde) { }
        public DateTime DateDernierRetrait { get; private set; }

        public void Retrait(decimal montant)
        {
            decimal ancienSolde = Solde;
            base.Retrait(montant);
            if (ancienSolde > Solde)
            {
                DateDernierRetrait = DateTime.Now;
            }
        }

        protected override decimal CalculInteret()
        {
            return Solde * .045M;
        }
    }
}
