using System;

namespace EnergeticDevelopment.PowerPlants
{
    public class PlantFactory 
    {
        public IPlant Create(PlantType plantType) =>
            plantType switch
            {
                PlantType.Coal => new CoalPlant(),
                PlantType.Solar => new SolarPlant(),
                PlantType.Nuclear => new NuclearPlant(),
                PlantType.Fusion => new FusionPlant(),
                PlantType.Annihilation => new AnihilationPlant(),
                _ => throw new ArgumentException($"Unsupported plant type: {plantType}")
            };
    }
}