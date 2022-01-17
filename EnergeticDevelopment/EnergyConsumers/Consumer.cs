using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.EnergyConsumers
{
    public abstract class Consumer : IConsumer
    {
        private readonly double _amount;

        public Consumer(double amount)
        {
            _amount = amount;
        }

        public Resource Consume()
        {
            return new Resource(ResourceType.Energy, _amount);
        }
    }
}