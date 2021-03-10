using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Bus:Car
    {
        public int PassengerCount;
        public Bus(int passengerCount)
        {
            PassengerCount = passengerCount;
        }

        public override string Info()
        {
            //Test();
            //horsePower = 200;
            //Test();
            //Brand = "BMW";
            //_speed = 50;
            return $"{Brand} {Model} {Engine} {horsePower} {Price} {PassengerCount}";
        }
    }
}
