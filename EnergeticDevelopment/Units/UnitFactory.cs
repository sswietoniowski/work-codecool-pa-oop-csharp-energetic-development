using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.Units
{
    public class UnitFactory
    {
        public IUnit Create(ResourceType resourceType) =>
            resourceType switch
            {
                ResourceType.Coal => new CoalUnit(),
                ResourceType.Uranium => new UraniumUnit(),
                ResourceType.Helium => new HeliumUnit(),
                ResourceType.Antimatter => new AntimatterUnit(),
                ResourceType.Energy => new EnergyUnit(),
                _ => new NoUnit(),
            };
    }
}