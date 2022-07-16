using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Bicycle : Vehicle
    {
       
        public override double Drive()
        {
           return Millage++;
        }
        public override void ShowInfo(string color, string brand, double millage)
        {

            Color = color;
            Brand = brand;
            Millage = millage;
            Console.WriteLine($"Car: Color is {Color} , Brand is {Brand}, Millage is {Millage}");
        }
    }
}
