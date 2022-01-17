using System;

namespace EnergeticDevelopment.Mines
{
    public class PlantFactory 
    {
        public IPlant Create(PlantType plantType)
        {
            return plantType switch
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
}