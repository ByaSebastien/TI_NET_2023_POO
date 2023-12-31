﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_NET_2023_POO.Demo.Models
{
    public class Person
    {
        public Person(int id, string name, string phoneNumber, string address)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}\n" +
                   $"Name : {Name}\n" +
                   $"Phone : {PhoneNumber}";
        }
    }
}
