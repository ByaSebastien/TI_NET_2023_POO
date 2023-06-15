﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Exercices.Models
{
    public class Banque
    {
        private Dictionary<string, Courant> _comptes;

        public Dictionary<string, Courant> Comptes
        {
            get { return _comptes ??= new Dictionary<string, Courant>(); }
        }

        public string Name { get; set; }

        public Courant this[string numero]
        {
            get
            {
                Comptes.TryGetValue(numero, out Courant c);
                return c;
            }
        }

        public void Ajouter(Courant c)
        {
            Comptes.Add(c.Numero, c);
        }
        
        public void Supprimer(string numero)
        {
            Comptes.Remove(numero);
        }

        public decimal AvoirDesComptes(Personne p)
        {
            decimal somme = 0;

            foreach(Courant c in Comptes.Values)
            {
                if(p == c.Titulaire)
                {
                    somme += c;
                }
            }

            return somme;
        }
    }
}
