using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxiDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            Class taxi = new Class();

            // pengertian nilai properties
            taxi.DriverName = "Pak Supri";
            taxi.OnDuty = true;
            taxi.NumPassanger = 25;

            // pemanggil method
            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
        }
    }
}