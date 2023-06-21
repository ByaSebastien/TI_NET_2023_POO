using System.Numerics;
using TI_NET_2023_POO.Demo.Exceptions;
using TI_NET_2023_POO.Demo.Models;
using TI_NET_2023_POO.Demo.Models.Vehicules;
using TI_NET_2023_POO.Demo.Services;
using TI_NET_2023_POO.Demo.Utils;
using static TI_NET_2023_POO.Demo.Utils.Dice;

//Casting c = new Casting()
//{
//    Name = "Casting DMC",
//    Entities = new List<Hero>()
//    {
//        new Hero("Dante"),
//        new Hero("Vergil"),
//        new Hero("Nero")
//    },
//};

////c["Dante"].Stats[StatType.Hp] = 800000000;



//Hero fusion = c.Entities[0] + c.Entities[1];
//c.Entities.Add(fusion);

//Hero dante = new Hero("Dante");


//foreach (Hero entity in c.Entities)
//{
//    Console.WriteLine(entity);
//}

//dante = c.Entities[1];

//Console.WriteLine(dante);

//Employee noreen = new Employee();

//List<Vehicule> catalog = new List<Vehicule>()
//{
//    new Voiture()
//    {
//        Marque = "Dodge",
//        Prix = 100000,
//        Couleur = "Noir",
//    },
//    new Avion()
//    {
//        Marque = "Diamond",
//        Prix = 200000,
//        Speed = 300
//    }
//};


//foreach(Vehicule v in catalog)
//{
//    Console.WriteLine(v);
//    v.Deplacer();
//}

//Console.WriteLine(Vehicule._id);


//Console.WriteLine(Throw(5,3));

//string s = "  cou  cou  ";

//Console.WriteLine(s.SuperCamelCase("TEST"));

//Console.WriteLine(Extention.SuperCamelCase(s,"TEST"));

//Console.WriteLine(s.Trim(true));


//IBookService bookService = new BookService();

//bookService.Add(new Book());

//IBateau a = new Amphibie();

//a.Tourne();

//Console.WriteLine(Vehicule._id);
//Vehicule v1 = new Voiture();
//Console.WriteLine(Vehicule._id);
//Vehicule v2 = new Avion();
//Console.WriteLine(Vehicule._id);
//v1.Marque = "Dodge";
//v1.Prix = 10000;


//v2.Marque = "Diamond DA-40";
//v2.Prix = 250000;

//Console.WriteLine(v1);
//Console.WriteLine(v2);

//if (v1 == v2)

//    Vehicule.Jammy();

//IBookService bookService = new BookService();

////bookService.Add(new Book());

//List<Vehicule> vehicules = new List<Vehicule>();
//Garage g = new Garage();

//g.Vehicules.Add(v1);
//g.Vehicules.Add(v2);

//foreach (Vehicule v in g.Vehicules)
//{
//    v.Deplacer();
//}
//Console.WriteLine(g[10]);

//Dictionary<int, Vehicule> vehiculesDict = new Dictionary<int, Vehicule>();

//vehiculesDict.Add(v1.Id, v1);
//vehiculesDict.Add(v2.Id, v2);

//foreach(KeyValuePair<int,Vehicule> kvp in vehiculesDict)
//{
//    Console.WriteLine(kvp.Key);
//    kvp.Value.Deplacer();
//}



//foreach(Vehicule v in vehiculesDict.Values)
//{
//    Console.WriteLine(v);
//}

//IBookService bookService = new BookService();

//Console.WriteLine(bookService.Add(new Book()).ISBN);

//Book b = new Book();
//Console.WriteLine(b.ISBN);

#region demo2 indexeur

//Catalog catalog1 = new Catalog();

//catalog1.Name = "Pas mal!";

//Person person1 = new Person()
//{
//    Id = 1,
//    Name = "Georges",
//    PhoneNumber = "01234",
//    Address = "Rue cerisier numero 18"
//};

//catalog1.AddPerson(person1);

//Console.WriteLine(catalog1["01234"]);

//catalog1["123"] = new Person()
//{
//    Id = 2,
//    Name = "Seb",
//    PhoneNumber = "123",
//    Address = "test"
//};

//Console.WriteLine(catalog1["123"]);
//Dictionary<int,string> communes = new Dictionary<int,string>();

//communes.Add(4347, "Fexhe le Haut Clocher");

//Console.WriteLine(communes[4347]);
//Console.WriteLine(communes.ContainsKey(4347));

#endregion

Vehicule v = new Voiture("Dodge", 10000, "Noir");

try
{
    v.Prix = 5;
    Console.WriteLine("Success");
}catch(VehiculeException e)
{
    Console.WriteLine(e.Message);
}catch(ArgumentOutOfRangeException e)
{
    v.Prix = 0;
    Console.WriteLine(e.Message);
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine(v);