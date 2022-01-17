using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class SolarPlant : IPlant
    {
        public Resource Consume()
        {
            return new NoResource();
        }

        public Resource Produce()
        {
            return new Resource(new EnergyUnit(), 2);
        }
    }
}