using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public static int Count = 0;
        public Person Parent { get; set; }

        //static constructor - can not call!!!, only work first instance!!!, must be parametrless!!!
        static Person()
        {
            Console.WriteLine("First person created");
        }

        public Person()
        {
            Console.WriteLine("Person created");
        }

        public static void Print()
        {
            Console.WriteLine("Person static method");
        }

        public void Test()
        {
            Count = 2;
        }
    }
}
