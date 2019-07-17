using System;
using System.Collections.Generic;

namespace diggers_and_fliers
{
    class Program
    {
        static void Main(string[] args)
        {
            SkyAnimal parakeet = new SkyAnimal { Name = "parakeet" };
            LandAnimal earthworm = new LandAnimal { Name = "earthworm" };
            WaterAndLandAnimal terrapin = new WaterAndLandAnimal { Name = "terrapin" };
            WaterAnimal bettaFish = new WaterAnimal { Name = "betta fish" };
            LandAnimal gerbil = new LandAnimal { Name = "gerbil" };
            SkyAnimal finch = new SkyAnimal { Name = "finch" };

            var SkyContainer = new SkyContainer();
            SkyContainer.SkyAnimals = new List<IFlying>() { finch, parakeet };

            var LandContainer = new LandContainer();
            LandContainer.LandAnimals = new List<IWalking>() { gerbil, earthworm };

            var WaterContainer = new WaterContainer();
            WaterContainer.WaterAnimals = new List<ISwimming>() { bettaFish, terrapin };

            parakeet.Fly();
        }
    }
}
