using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models
{
    public class Employee : Person
    {
        public Employee(int id, string name, string phoneNumber, string address) : base(id, name, phoneNumber, address)
        {
        }

        public int Salaire { get; set; }
    }
}
