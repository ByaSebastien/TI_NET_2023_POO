using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Exceptions
{
    public class VehiculeException : Exception
    {
        public VehiculeException() : base ("Vehicule exception")
        {
        }

        public VehiculeException(string? message) : base(message)
        {
        }
    }

    public class NotFiveVehiculeException : VehiculeException
    {
        public NotFiveVehiculeException() : base("Je ne veux pas de cinq!!!!")
        {
        }

        public NotFiveVehiculeException(string? message) : base(message)
        {
        }
    }
}
