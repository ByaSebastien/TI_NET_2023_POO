using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Exercices.Models
{
    public class Banque
    {
        private Dictionary<string, Compte> _comptes;

        public Dictionary<string, Compte> Comptes
        {
            get { return _comptes ??= new Dictionary<string, Compte>(); }
        }

        public string Name { get; set; }

        public Compte this[string numero]
        {
            get
            {
                Comptes.TryGetValue(numero, out Compte c);
                return c;
            }
        }

        public void Ajouter(Compte c)
        {
            c.PassageEnNegatifEvent += PassageEnNegatifAction;
            Comptes.Add(c.Numero, c);
        }
        
        public void Supprimer(string numero)
        {
            Comptes.Remove(numero);
        }

        public decimal AvoirDesComptes(Personne p)
        {
            decimal somme = 0;

            foreach(Compte c in Comptes.Values)
            {
                if(p == c.Titulaire)
                {
                    somme += c;
                }
            }

            return somme;
        }

        private void PassageEnNegatifAction(Compte c)
        {
            Console.WriteLine($"Le compte {c.Numero} vient de passer en négatif.");
        }
    }
}
