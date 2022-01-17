using System;
using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.PowerPlants
{
    public interface IPlant
    {
        public PlantType PlantType { get; }
        Resource Consume();
        Resource Produce();
    }
}