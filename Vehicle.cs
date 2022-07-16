using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal abstract class Vehicle
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public double Millage { get; set; }

        public Vehicle()
        {
            
        }

        public Vehicle(string color, string brand, double millage)
        {
            this.Color = color;
            this.Brand = brand;
            this.Millage = millage;
        }

        public virtual void ShowInfo(string color, string brand, double millage)
        {
            Console.WriteLine($"Color is {Color} , Brand is {Brand}, Millage is {Millage}");
        }
        public abstract double Drive();
    }
}
