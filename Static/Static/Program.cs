using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Person.Count);
            //Person p1 = new Person();
            //Person p2 = new Person();
            //Person p3 = new Person();
            //Person.Print();

            Helper.Show();
            Helper.MyProperty = 10;
        }

        //public static void ShowMessage()
        //{
        //    Console.WriteLine("Static method");
        //}
    }
}
