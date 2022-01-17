using EnergeticDevelopment.Mines;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Resources
{
    public class Resource
    {
        public IUnit Unit { get; }
        public double Value { get; }

        public Resource(IUnit unit, double value)
        {
            Unit = unit;
            Value = value;
        }
    }
}