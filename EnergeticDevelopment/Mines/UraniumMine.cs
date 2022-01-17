using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class UraniumMine : IMine
    {
        public Resource Produce()
        {
            return new Resource(new UraniumUnit(), 100);
        }
    }
}