using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class MoonMine : IMine
    {
        public Resource Produce()
        {
            return new Resource(new HeliumUnit(), 10);
        }
    }
}