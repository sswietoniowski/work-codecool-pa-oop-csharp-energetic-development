using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.PowerPlants
{
    public class FusionPlant : Plant
    {
        public FusionPlant() : base(PlantType.Fusion, ResourceType.Helium, 1, ResourceType.Energy, 20_000) {}
    }
}