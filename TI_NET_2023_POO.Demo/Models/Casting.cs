using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models
{
    public class Casting
    {
        public string Name { get; set; }
        public List<Hero> Entities {get; set;}

        public Hero? this[string name]
        {
            get
            {
                foreach(Hero e in Entities)
                {
                    if (e.Name == name)
                    {
                        return e;
                    }
                }
                return null;
            }
            set
            {
                for(int i = 0 ; i < Entities.Count; i++)
                {
                    if (Entities[i].Name == name)
                    {
                        Entities[i] = value;
                    }
                }
                Entities.Add(value);
            }
        }
    }
}
