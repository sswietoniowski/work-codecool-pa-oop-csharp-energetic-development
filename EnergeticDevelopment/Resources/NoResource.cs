using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Resources
{
    public class NoResource : Resource
    {
        public NoResource() : base(new NoUnit(), 0)
        {
        }
    }
}