using TI_NET_2023_POO.Exercices.Models;

Personne p = new Personne();

p.Nom = "Bya";
p.Prenom = "Seb";
p.DateNaiss = new DateTime(1991, 3, 27);

Courant c = new Courant();
c.Numero = "1";
c.LigneDeCredit = 500;
c.Titulaire = p;

Console.WriteLine($"{c.Numero} : {c.Titulaire.Nom} : {c.Solde}");
c.Depot(1000);
Console.WriteLine($"{c.Numero} : {c.Titulaire.Nom} : {c.Solde}");
c.Retrait(1250);
Console.WriteLine($"{c.Numero} : {c.Titulaire.Nom} : {c.Solde}");



Personne p2 = new Personne()
{
    Nom = "Bond",
    Prenom = "James",
    DateNaiss = new DateTime(1950, 2, 23)
};

