using System;
using EnergeticDevelopment.EnergyConsumers;
using EnergeticDevelopment.Mines;
using EnergeticDevelopment.PowerPlants;

namespace EnergeticDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            // configure mines, plants and consumer
            ResourceStorage resourceStorage = ResourceStorage.Instance;
            MineFactory mineFactory = new MineFactory();
            PlantFactory plantFactory = new PlantFactory();
            
            for (int i = 0; i < 100; i++)
            {
                resourceStorage.AddMine(mineFactory.Create(MineType.Coal));
            }
            resourceStorage.AddMine(mineFactory.Create(MineType.Uranium));
            resourceStorage.AddPlant(plantFactory.Create(PlantType.Nuclear));
            for (int i = 0; i < 10; i++)
            {
                resourceStorage.AddPlant(plantFactory.Create(PlantType.Coal));
            }
            resourceStorage.AddConsumers(new NewYork());

            // test whether this system could work for a given time
            try
            {
                for (int i = 1; i <= 30; i++)
                {
                    Console.WriteLine($"Day: {i}");
                    resourceStorage.Simulate();
                }
            }
            catch (BlackoutException exception)
            {
                Console.WriteLine("Not enough energy!");
            }
        }
    }
}