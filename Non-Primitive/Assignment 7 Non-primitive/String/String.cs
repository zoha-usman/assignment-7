
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = "Mosh";
            var lastname = "Hamedani";
            var fullname = firstname + "  " + lastname;
            var myfullname = string.Format("my name is{0}{1}", firstname, lastname);

            var names = new string[3] { "john", "jack", "mary" };
            var formattedNames = string.Join(",", names);
            
            Console.WriteLine(formattedNames);
            Console.ReadLine();

        }
    }
}
