using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Exercices.Models
{
    public class Courant : Compte
    {
        public Courant (string numero, Personne titulaire) : base(numero,titulaire) { }
        public Courant (string numero, Personne titulaire, decimal solde) : base(numero,titulaire,solde) { }
        public Courant (Personne titulaire, string numero, decimal ligneDeCredit) : base(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }

        private decimal _ligneDeCredit;

        public decimal LigneDeCredit
        {
            get 
            {
                return _ligneDeCredit; 
            }
            private set
            {
                if(value < 0)
                {
                    throw new InvalidOperationException("WTF?!");
                }
                _ligneDeCredit = value;
            }
        }

        public override void Retrait(decimal montant)
        {
            bool estPositif = Solde >= 0;
            Retrait(montant,LigneDeCredit);
            if(estPositif && Solde < 0)
            {
                RaisePassageEnNegatifEvent();
            }
        }

        protected override decimal CalculInteret()
        {
            //if(Solde >= 0)
            //{
            //    return Solde * 0.03M;
            //}
            //return Solde * 0.0975M;

            return Solde * (Solde >= 0 ? .03M : .0975M);
        }
    }
}
