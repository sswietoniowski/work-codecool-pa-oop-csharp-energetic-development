using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class FusionPlant : IPlant
    {
        public Resource Consume()
        {
            return new Resource(new HeliumUnit(), 1);
        }

        public Resource Produce()
        {
            return new Resource(new EnergyUnit(), 20_000);
        }
    }
}