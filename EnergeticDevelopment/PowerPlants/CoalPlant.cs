using EnergeticDevelopment.Mines;
using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.PowerPlants
{
    public class CoalPlant : Plant
    {
        public CoalPlant() : base(PlantType.Coal, ResourceType.Coal, 100, ResourceType.Energy, 7) {}
    }
}