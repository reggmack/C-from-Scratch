using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthDate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthDate;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
