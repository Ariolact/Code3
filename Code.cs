using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        public string name;
        public int age;
        PersonsAttributes personsAttributes;

        public Person(string name, int age, PersonsAttributes personsAttributes)
        {
            this.name = name;
            this.age = age;
            this.personsAttributes = personsAttributes;
        }
    }

    class PersonsAttributes
    {
        int height;
        int size;
        int width;
        public PersonsAttributes(int height, int size, int width)
        {
            this.height = height;
            this.size = size;
            this.width = width;
        }
    }
}