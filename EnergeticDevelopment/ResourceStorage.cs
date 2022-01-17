using System;
using System.Collections.Generic;
using EnergeticDevelopment.EnergyConsumers;
using EnergeticDevelopment.Mines;
using EnergeticDevelopment.PowerPlants;
using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment
{
    public class ResourceStorage
    {
        private static ResourceStorage? _resourceStorage;
        public static ResourceStorage Instance => _resourceStorage ??= new ResourceStorage();

        private List<IMine> _mines = new();
        private List<IPlant> _plants = new();
        private List<IConsumer> _consumers = new();
        private Dictionary<ResourceType, double> _resources = new();
        private double _energy = 0;
        
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
            Mine();

            Produce();

            Consume();
        }
        
        private void Mine()
        {
            foreach (var mine in _mines)
            {
                var resource = mine.Produce();

                Console.WriteLine($"Mine: {mine.MineType} Produced: {resource}");

                var totalAmount = _resources?[resource.ResourceType] ?? 0;
                totalAmount += resource.Amount;
                _resources![resource.ResourceType] = totalAmount;
                
                Console.WriteLine($"Resource Type: {resource.ResourceType}, Total Amount: {totalAmount}");
            }
        }
        
        private void Produce()
        {
            foreach (var plant in _plants)
            {
                var resourceConsumed = plant.Consume();

                Console.WriteLine($"Plant: {plant.PlantType} Requires: {resourceConsumed}");

                if (_resources.ContainsKey(resourceConsumed.ResourceType))
                {
                    var totalAmount = _resources[resourceConsumed.ResourceType];
                    if (totalAmount >= resourceConsumed.Amount)
                    {
                        _resources[resourceConsumed.ResourceType] -= resourceConsumed.Amount;
                        var resourceProduced = plant.Produce();
                        Console.WriteLine($"Produced: {resourceProduced}");
                        _energy += resourceProduced.Amount;
                        Console.WriteLine($"Total energy: {_energy}");
                    }
                }
                else
                {
                    Console.WriteLine("Not enough resources, so this plant is not producing energy...");
                }
            }
        }
        
        private void Consume()
        {
            foreach (var consumer in _consumers)
            {
                var consumedResource = consumer.Consume();

                Console.WriteLine($"Consumer requires: {consumedResource}");
                
                if (consumedResource.Amount > _energy)
                {
                    throw new BlackoutException();
                }

                _energy -= consumedResource.Amount;

                Console.WriteLine($"Energy left: {_energy}");
            }
        }
    }
}