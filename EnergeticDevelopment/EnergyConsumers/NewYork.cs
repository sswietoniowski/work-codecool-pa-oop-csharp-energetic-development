using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.EnergyConsumers
{
    public class NewYork : IConsumer
    {
        public Resource Consume()
        {
            return new Resource(new EnergyUnit(), 10_000);
        }
    }
}