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
            
            resourceStorage.AddMine(mineFactory.Create(MineType.Uranium));
            for (int i = 0; i < 100; i++)
            {
                resourceStorage.AddMine(mineFactory.Create(MineType.Coal));
            }
            resourceStorage.AddPlant(plantFactory.Create(PlantType.Nuclear));
            for (int i = 0; i < 10; i++)
            {
                resourceStorage.AddPlant(plantFactory.Create(PlantType.Coal));
            }
            // resourceStorage.AddPlant(plantFactory.Create(PlantType.Solar));
            resourceStorage.AddConsumers(Consumer.NewYork);

            // test whether this system could work for a given time
            try
            {
                for (int i = 1; i <= 30; i++)
                {
                    Console.WriteLine(new String('=', 80));
                    Console.WriteLine($"Day: {i}");
                    resourceStorage.Simulate();
                }

                Console.WriteLine("Test passed, system produced enough energy");
            }
            catch (BlackoutException exception)
            {
                Console.WriteLine("Not enough energy!");
            }
        }
    }
}