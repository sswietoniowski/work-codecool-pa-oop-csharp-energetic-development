using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.PowerPlants
{
    public class AnihilationPlant : Plant
    {
        public AnihilationPlant() : base(PlantType.Annihilation, ResourceType.Antimatter, 1, ResourceType.Energy, 25_000) {}
    }
}