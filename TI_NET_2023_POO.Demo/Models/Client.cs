using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models
{
    public class Client : Person
    {
        public Client(int id, string name, string phoneNumber, string address) : base(id, name, phoneNumber, address)
        {
        }

        public bool estUnPigeon { get; set; }
    }
}
