using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonsAttributes attributes = new PersonsAttributes(178, 80, 100);
            Person person = new Person("Marek", 1, attributes);
            Console.WriteLine(person.name + "" + person.age);
            Console.ReadLine();
        }
    }
}
