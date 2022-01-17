using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.EnergyConsumers
{
    public class World : IConsumer
    {
        public Resource Consume()
        {
            return new Resource(new EnergyUnit(), 6_000_000);
        }
    }
}