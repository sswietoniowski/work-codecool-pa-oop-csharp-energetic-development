using System;
using EnergeticDevelopment.EnergyConsumers;
using EnergeticDevelopment.Mines;

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
            for (int i = 0; i < 30; i++)
            {
                resourceStorage.Simulate();
            }
        }
    }
}