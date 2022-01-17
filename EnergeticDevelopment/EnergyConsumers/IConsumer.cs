using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.EnergyConsumers
{
    public interface IConsumer
    {
        Resource Consume();
    }
}