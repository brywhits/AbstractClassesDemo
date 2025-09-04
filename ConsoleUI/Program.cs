using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var car1 = new Car() // Object Initializer Syntax
            {
                Year = "2024", 
                Make = "Hyundai", 
                Model = "Sonata", 
                HasTrunk = true
            };

            var moto1 = new Moto() 
            { 
                Year = "2025", 
                Make = "Harley", 
                Model = "Davison", 
                HasSideCart = true 
            };

            Vehicle car2 = new Car()
            {
                Year = "2030",
                Make = "Tesla",
                Model = "Y",
                HasTrunk = true,
            };

            Vehicle moto2 = new Moto()
            {
                Year = "2040", 
                Make = "Yawasaki", 
                Model = "M4", 
                HasSideCart = true
            };
            
            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>() { car1, car2, moto1, moto2 };
            

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            foreach (var ride in vehicles)
            {
                Console.WriteLine($"{ride.Year} {ride.Make} {ride.Model} ");
                ride.DriveAbstract();
                ride.DriveVirtual();
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
