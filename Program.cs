using System;
namespace ConsoleApp46
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Vehicle car = new Car(100,2);
            
            car.ShowInfo("red", "bmw", 20);
            Vehicle bicycle = new Bicycle();
            bicycle.ShowInfo("pink", "mercedes", 18);
            car.Drive();
            car.Drive();
            Console.WriteLine($"Now millage for car is {car.Millage}");
            bicycle.Drive();
            Console.WriteLine($"Now millage for bicycle is {bicycle.Millage}");

          
            Car car2 = new Car(100, 5);
  
           
            car2.Drive();
            car2.Drive();
            car2.Drive();

            Console.WriteLine($"After driving car currentfuel {car2.CurrentFuel}");


        }
    }
}