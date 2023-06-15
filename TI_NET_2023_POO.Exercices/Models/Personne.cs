﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Exercices.Models
{
    public class Personne
    {

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaiss { get; set; }

        public static bool operator ==(Personne p1 , Personne p2)
        {
            return p1.Nom == p2.Nom && p1.Prenom == p2.Prenom && p1.DateNaiss == p2.DateNaiss;
        }

        public static bool operator !=(Personne p1, Personne p2)
        {
            return !(p1 == p2);
        }
    }
}
