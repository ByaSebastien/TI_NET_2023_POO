using TI_NET_2023_POO.ExoCarwash.Models;

Carwash c = new Carwash();

c.Traiter(new Voiture("1"));
Console.WriteLine("___________________________________");
c.Traiter(new Voiture("2"));
Console.WriteLine("___________________________________");
c.Traiter(new Voiture("3"));
Console.WriteLine("___________________________________");
c.Traiter(new Voiture("4"));
Console.WriteLine("___________________________________");
c.Traiter(new Voiture("5"));
Console.WriteLine("___________________________________");

c.CarwashDelegate(new Voiture("6"));