using System;
using System.Collections.Generic;
using System.Linq;

namespace _06SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n] ;
            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split()
                    .ToArray();
                var model = carInfo[0];
                var fuelAmount = double.Parse(carInfo[1]);
                var fuelConsumption = double.Parse(carInfo[2]);
                cars[i] = new Car(model, fuelAmount, fuelConsumption,0);
               

            }
            string command;
            while ((command = Console.ReadLine() )!= "End")

            {
                var tokens= command.Split().ToArray();
                var carModel = tokens[1];
                var amountOfKm =double.Parse(tokens[2]);

                cars.Where(c => c.Model == carModel).ToList().ForEach(c => c.Drive(amountOfKm));
               
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
