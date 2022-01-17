using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.EnergyConsumers
{
    public class Poland : IConsumer
    {
        public Resource Consume()
        {
            return new Resource(new EnergyUnit(), 40_000);
        }
    }
}