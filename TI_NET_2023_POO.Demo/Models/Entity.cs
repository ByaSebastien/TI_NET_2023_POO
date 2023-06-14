using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models
{
    public enum Race
    {
        Humain,
        Nain
    }
    public partial class Entity
    {

        #region Attributs

        private string _name;

        #endregion


        #region Constructeurs

        public Entity(string name)
        {
            Random r = new Random();
            Name = name;
            Hp = r.Next(5, 10);
            Strength = r.Next(5, 10);
            Stamina = r.Next(5, 10);
        }

        #endregion

        #region Propriétés

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Trim() == "")
                {
                    return;
                }
                _name = value.Trim();
            }
        }

        public int Hp { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }

        #endregion

        #region Methodes

        public override string ToString()
        {
            return $"Nom : {Name}\n" +
                   $"Pv : {Hp}\n" +
                   $"Endurance : {Stamina}\n";
        }

        #endregion
    }
}
