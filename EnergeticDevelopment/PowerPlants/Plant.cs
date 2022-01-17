using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.PowerPlants
{
    public abstract class Plant : IPlant
    {
        private readonly ResourceType _consumedResourceType;
        private readonly double _consumedResourceAmount;
        private readonly ResourceType _producedResourceType;
        private readonly double _producedResourceAmount;
        public PlantType PlantType { get; }

        public Plant(PlantType plantType, ResourceType consumedResourceType, double consumedResourceAmount,
            ResourceType producedResourceType, double producedResourceAmount)
        {
            PlantType = plantType;
            _consumedResourceType = consumedResourceType;
            _consumedResourceAmount = consumedResourceAmount;
            _producedResourceType = producedResourceType;
            _producedResourceAmount = producedResourceAmount;
        }

        public Resource Consume()
        {
            return new Resource(_consumedResourceType, _consumedResourceAmount);
        }

        public Resource Produce()
        {
            return new Resource(_producedResourceType, _producedResourceAmount);
        }
    }
}