using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class person
    {
        public string FirstName;
        public string LastName;
        
        public void Introduce()
            {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var john = new person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
        }
    }
}
