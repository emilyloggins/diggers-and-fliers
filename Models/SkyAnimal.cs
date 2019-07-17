using System;

namespace diggers_and_fliers
{
    public class SkyAnimal : Animal, IFlying
    {
        public void Fly()
        {
            Console.WriteLine($"{Name} is now flying");
        }
    }
}