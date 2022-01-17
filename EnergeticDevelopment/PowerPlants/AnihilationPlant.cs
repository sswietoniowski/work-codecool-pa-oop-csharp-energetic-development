using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class AnihilationPlant : IPlant
    {
        public Resource Consume()
        {
            return new Resource(new AntimatterUnit(), 1);
        }

        public Resource Produce()
        {
            return new Resource(new EnergyUnit(), 25_000);
        }
    }
}