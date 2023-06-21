using TI_NET_2023_POO.Exercices.Exceptions;
using TI_NET_2023_POO.Exercices.Models;

Banque banque = new Banque()
{
    Name = "Les voleurs de grands chemins",
};

Personne p = new Personne("Bya","Seb", new DateTime(1991,3,27));

Courant c = new Courant("1",p,500);

Personne p2 = new Personne("Bond", "James", new DateTime(1950, 2, 23));

Courant c2 = new Courant("2", p2, 10000);

banque.Ajouter(c);
banque.Ajouter(c2);

p.Equals(p2);



//Console.WriteLine($"{banque["1"].Numero} : {banque["1"].Titulaire.Nom} : {banque["1"].Solde}");
//banque["1"].Depot(1000);
//Console.WriteLine($"{banque["1"].Numero} : {banque["1"].Titulaire.Nom} : {banque["1"].Solde}");
//banque["1"].Retrait(1250);
//Console.WriteLine($"{banque["1"].Numero} : {banque["1"].Titulaire.Nom} : {banque["1"].Solde}");


//Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");
//banque["2"].Depot(2000);
//Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");
//banque["2"].Retrait(1000);
//Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");

//Console.WriteLine(1000 + c2);

//Console.WriteLine(banque.AvoirDesComptes(p2));

c2.Depot(1000);
Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");
c2.AppliquerInteret();
Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");

ICustomer customer = c2;
IBanker banker = c2;

customer.Depot(1000);

banker.AppliquerInteret();

try
{
    c.Depot(-100);
    c.Retrait(1000000);
    Compte c3 = new Courant(new Personne("Doe", "John", new DateTime(1923, 1, 1)), "3", -500);
}
catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch(SoldeInsufisantException e)
{
    Console.WriteLine(e.Message);
}
catch(InvalidOperationException e)
{
    Console.WriteLine(e.Message);
}
catch(Exception)
{
    throw;
}


