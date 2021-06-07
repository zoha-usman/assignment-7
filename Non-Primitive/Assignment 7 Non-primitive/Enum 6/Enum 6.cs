using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            Console.ReadLine();
            var person = new Person() { Age = 20 };
            Makeold(person);
            Console.WriteLine(person.Age);
            Console.ReadLine();

        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void Makeold(Person person)
        {
            person.Age += 10;
        }
    }
}
