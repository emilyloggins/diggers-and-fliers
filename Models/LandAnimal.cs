
using System;

namespace diggers_and_fliers
{
    public class LandAnimal : Animal, IWalking, IDigging
    {
        public int Speed { get; set; }
        public string NumberOfLegs { get; set; }
        public void Run()
        {
            Console.WriteLine($"{Name} is now running");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is now walking");
        }
        public void Dig()
        {
            Console.WriteLine($"{Name} is now digging");
        }
    }
}