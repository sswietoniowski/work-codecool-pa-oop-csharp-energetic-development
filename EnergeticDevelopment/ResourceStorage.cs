using System.Collections.Generic;
using EnergeticDevelopment.EnergyConsumers;
using EnergeticDevelopment.Mines;

namespace EnergeticDevelopment
{
    public class ResourceStorage
    {
        private static ResourceStorage? _resourceStorage;
        public static ResourceStorage Instance => _resourceStorage ??= new ResourceStorage();

        private List<IMine> _mines = new List<IMine>();
        private List<IPlant> _plants = new List<IPlant>();
        private List<IConsumer> _consumers = new List<IConsumer>();
        private ResourceStorage() {}

        public void AddMine(IMine mine)
        {
            _mines.Add(mine);
        }

        public void AddPlant(IPlant plant)
        {
            _plants.Add(plant);
        }

        public void AddConsumers(IConsumer consumer)
        {
            _consumers.Add(consumer);
        }

        public void Simulate()
        {
            foreach (var mine in _mines)
            {
                // gather created resources
            }

            foreach (var plant in _plants)
            {
                // test whether plant can work & how long
            }
            
            // check whether consumer has required resources
        }
    }
}