using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.PowerPlants
{
    public class SolarPlant : Plant
    {
        public SolarPlant() : base(PlantType.Solar, ResourceType.Void, 0, ResourceType.Energy, 2) {}
    }
}