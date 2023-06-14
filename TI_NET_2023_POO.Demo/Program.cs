using TI_NET_2023_POO.Demo.Models;


Casting c = new Casting()
{
    Name = "Casting DMC",
    Entities = new List<Entity>()
    {
        new Entity("Dante"),
        new Entity("Vergil"),
        new Entity("Nero")
    },
};

c["Dante"].Stats[StatType.Hp] = 800000000;

Console.WriteLine(c["Dante"]);

//foreach (Entity entity in c.entities)
//{
//    Console.WriteLine(entity);
//}