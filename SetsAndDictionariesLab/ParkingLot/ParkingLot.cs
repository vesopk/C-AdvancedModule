using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    public class ParkingLot
    {
       public static void Main()
        {
            var parkedCarsNumbers = new HashSet<string>();

            var inputline = Console.ReadLine();
            while (true)
            {
                if (inputline == "END")
                {
                    break;
                }

                var carInfo = inputline.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var direction = carInfo[0];
                var carNumber = carInfo[1];

                if (direction == "IN")
                {
                    parkedCarsNumbers.Add(carNumber);
                }
                else if (direction == "OUT") 
                {
                    parkedCarsNumbers.Remove(carNumber);
                }
                inputline = Console.ReadLine();
            }
            if (parkedCarsNumbers.Count > 0)
            {
                foreach (var car in parkedCarsNumbers.OrderBy(c => c))
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
