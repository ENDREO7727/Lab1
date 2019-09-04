using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, last, age;
            Console.WriteLine("Enter your first name: ");
            first = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            last = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1} {2}", first, last, age);
            Console.ReadLine();
        }
    }
}
