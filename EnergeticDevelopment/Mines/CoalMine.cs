using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class CoalMine : IMine
    {
        public Resource Produce()
        {
            return new Resource(new CoalUnit(), 40);
        }
    }
}