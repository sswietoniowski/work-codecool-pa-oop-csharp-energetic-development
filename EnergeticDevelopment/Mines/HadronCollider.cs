using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class HadronCollider : IMine
    {
        public Resource Produce()
        {
            return new Resource(new AntimatterUnit(), 1 / 7.0);
        }
    }
}