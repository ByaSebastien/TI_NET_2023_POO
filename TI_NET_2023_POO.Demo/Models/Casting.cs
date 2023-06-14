using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models
{
    public class Casting
    {
        public List<Entity> entities {get; set;}

        public Entity? this[string name]
        {
            get
            {
                foreach(Entity e in entities)
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
                for(int i = 0 ; i < entities.Count; i++)
                {
                    if (entities[i].Name == name)
                    {
                        entities[i] = value;
                    }
                }
            }
        }
    }
}
