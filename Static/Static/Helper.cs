using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    //static class - all members must be static!!!,cann't get instance!!!, cann't get inheretance!!!
    public static class Helper
    {
        public static int MyProperty { get; set; }

        static Helper()
        {
            Console.WriteLine("Helper first time worked");
        }
        public static void Show()
        {
            Console.WriteLine("Helper");
        }
    }

    
}
