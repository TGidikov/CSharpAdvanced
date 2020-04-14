using System;
using System.Collections.Generic;
using System.Linq;

namespace _07TruckTour
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var pumps = new Queue<int>();



            int cnt = 0;

            for (int i = 0; i < n; i++)
            {

                int[] currPump = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();
                pumps.Enqueue(currPump[0]);
                pumps.Enqueue(currPump[1]);


            }
           

            while (true)
            {


                var copy = new Queue<int>(pumps);

                long litres = copy.Dequeue();
                long distance = copy.Dequeue();

                if (litres < distance)
                {
                    pumps.Enqueue(pumps.Dequeue());
                    pumps.Enqueue(pumps.Dequeue());
                }
                else if (litres >= distance)
                {
                    long leftFuel = litres - distance;

                    while (copy.Any())
                    {
                        var litresInternal = copy.Dequeue();
                        var distanceInternal = copy.Dequeue();

                        if (litresInternal + leftFuel >= distanceInternal)
                        {
                            leftFuel = litresInternal + leftFuel - distanceInternal;
                        }
                        else
                        {
                            pumps.Enqueue(pumps.Dequeue());
                            pumps.Enqueue(pumps.Dequeue());
                            leftFuel = -1;
                            break;
                        }
                    }

                    if (leftFuel >= 0)
                    {
                        Console.WriteLine(cnt);
                        break;
                    }
                }
                cnt++;
            }
        }
    }
}
