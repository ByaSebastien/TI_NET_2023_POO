﻿using TI_NET_2023_POO.Demo.Models;


//Casting c = new Casting()
//{
//    Name = "Casting DMC",
//    Entities = new List<Entity>()
//    {
//        new Entity("Dante"),
//        new Entity("Vergil"),
//        new Entity("Nero")
//    },
//};

//c["Dante"].Stats[StatType.Hp] = 800000000;

//Console.WriteLine(c["Dante"]);

//foreach (Entity entity in c.entities)
//{
//    Console.WriteLine(entity);
//}

Catalog catalog1 = new Catalog();

catalog1.Name = "Pas mal!";

Person person1 = new Person()
{
    Id = 1,
    Name = "Georges",
    PhoneNumber = "01234",
    Address = "Rue cerisier numero 18"
};

catalog1.AddPerson(person1);

Console.WriteLine(catalog1["01234"]);

catalog1["123"] = new Person()
{
    Id = 2,
    Name = "Seb",
    PhoneNumber = "123",
    Address = "test"
};

Console.WriteLine(catalog1["123"]);
//Dictionary<int,string> communes = new Dictionary<int,string>();

//communes.Add(4347, "Fexhe le Haut Clocher");

//Console.WriteLine(communes[4347]);
//Console.WriteLine(communes.ContainsKey(4347));