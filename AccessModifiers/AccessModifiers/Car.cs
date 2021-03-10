using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{


    public class Car
    {
        //public string Brand;
        //public string Model;
        //public double Price;
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        private int _speed;
        protected int horsePower;
        //private readonly string _color;
        private string _color { get; }
        //public readonly double Engine=2; 
        public double Engine { get; }

        protected int WheelCount { get; private set; }

        public Car()
        {
            Console.WriteLine("Car created");
        }
        public Car(string brand, string model, double price, string color)
        {
            Brand = brand;
            Model = model;
            Price = price;
            _color = color;
            Engine = 2.5;
            //Speed = speed;
        }

        //encapsulation
        public int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (value > 0 && value <= 400)
                {
                    _speed = value;
                    return;
                }
                Console.WriteLine("Duzgun suret daxil edin!!!");
            }
        }
        //public void SetSpeed(int speed)
        //{
        //    if(speed>0 && speed <= 400)
        //    {
        //        _speed = speed;
        //        return;
        //    }
        //    Console.WriteLine("Duzgun suret daxil edin!!!");
        //}

        //public int GetSpeed()
        //{
        //    return _speed;
        //}

        protected void Test()
        {

        }

        public virtual string Info()
        {
            //Engine = 3.2;
            //_color = "";
            //Test();
            return $"{Brand} {_color} {Engine} {Model} {Price}";
        }
    }
}


