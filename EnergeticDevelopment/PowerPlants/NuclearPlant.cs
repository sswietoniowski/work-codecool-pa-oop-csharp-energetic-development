using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class NuclearPlant : IPlant
    {
        public Resource Consume()
        {
            return new Resource(new UraniumUnit(), 1);
        }

        public Resource Produce()
        {
            return new Resource(new EnergyUnit(), 10_000);
        }
    }
}