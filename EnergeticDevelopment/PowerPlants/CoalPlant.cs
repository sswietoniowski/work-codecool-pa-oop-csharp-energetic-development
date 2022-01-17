using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class CoalPlant : IPlant
    {
        public Resource Consume()
        {
            return new Resource(new CoalUnit(), 100);
        }

        public Resource Produce()
        {
            return new Resource(new EnergyUnit(), 7);
        }
    }
}