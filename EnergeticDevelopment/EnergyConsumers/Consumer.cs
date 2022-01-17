using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.EnergyConsumers
{
    public class Consumer : IConsumer
    {
        public static IConsumer World = new World();
        public static IConsumer Poland = new Poland();
        public static IConsumer NewYork = new NewYork();
        
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