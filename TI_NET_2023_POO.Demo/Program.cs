using TI_NET_2023_POO.Demo.Models;

List<Entity> entities = new List<Entity>()
{
    new Entity("Dante"),
    new Entity("Vergil"),
    new Entity("Nero")
};

Casting c = new Casting()
{
    entities = entities
};

c["Dante"].Stats[StatType.Hp] = 800000000;

Console.WriteLine(c["Dante"]);

//foreach (Entity entity in c.entities)
//{
//    Console.WriteLine(entity);
//}