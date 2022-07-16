using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Car: Vehicle
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; } 
        public double FuelForOneKm { get; set; }
        public override void ShowInfo(string color, string brand, double millage)
        {
            Color = color;
            Brand = brand;
            Millage = millage;
             Console.WriteLine($"Car: Color is {Color} , Brand is {Brand}, Millage is {Millage}");
        }

        public Car(double fuelCapacity, double fuelForOneKm )
        {
            this.FuelCapacity = fuelCapacity;
           
            this.FuelForOneKm = fuelForOneKm;

            CurrentFuel = FuelCapacity - FuelForOneKm * Millage;
        }
        public override double Drive()
        {           
            if (CurrentFuel > 0)
            {
                CurrentFuel--;
                Millage++;

            }
            else
            {
                Console.WriteLine("you ran out of fuel");
            }

            return Millage;
        }

        //public override void ShowInfo()
        //{
        //    //Color = "red";
        //    //Brand = "BMW";
        //    //Millage = 10;
        //}
    }
}
