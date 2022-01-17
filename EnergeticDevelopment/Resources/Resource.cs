using EnergeticDevelopment.Mines;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Resources
{
    public class Resource
    {
        public ResourceType ResourceType { get; }
        public double Amount { get; }

        public Resource(ResourceType resourceType, double amount)
        {
            ResourceType = resourceType;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"(resource: {ResourceType}, amount: {Amount})";
        }
    }
}