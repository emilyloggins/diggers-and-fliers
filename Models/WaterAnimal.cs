using System;

namespace diggers_and_fliers
{
    public class WaterAnimal : Animal, ISwimming
    {
        public int MaximumDepth { get; set; }
        public string Speed { get; set; }
        public void Run()
        {
            Console.WriteLine($"{Name} is now running");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is now walking");
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} is now swimming");
        }
    }
}