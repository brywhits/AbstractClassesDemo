using System;
namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is driving!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycles Virtual Drive Method!");
        }


    }
        

}

