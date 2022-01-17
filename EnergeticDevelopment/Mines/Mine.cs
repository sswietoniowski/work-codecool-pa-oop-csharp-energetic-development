using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.Mines
{
    public abstract class Mine : IMine
    {
        private readonly ResourceType _producedResourceType;
        private readonly double _producedResourceAmount;
        public MineType MineType { get; }

        public Mine(MineType mineType, ResourceType producedResourceType, double producedResourceAmount)
        {
            MineType = mineType;
            _producedResourceType = producedResourceType;
            _producedResourceAmount = producedResourceAmount;
        }
        
        public Resource Produce()
        {
            return new Resource(_producedResourceType, _producedResourceAmount);
        }
    }
}