using EnergeticDevelopment.Mines;
using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.PowerPlants
{
    public class NuclearPlant : Plant
    {
        public NuclearPlant() : base(PlantType.Nuclear, ResourceType.Uranium, 1, ResourceType.Energy, 10_000) {}
    }
}