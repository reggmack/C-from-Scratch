﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
           var person = new Person();
            person.BirthDate = new DateTime(1982, 1, 1);

            Console.WriteLine(person.Age);
        }
    }
}
