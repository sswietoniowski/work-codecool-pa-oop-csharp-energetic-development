using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public interface IMine
    {
        public MineType MineType { get; }
        
        Resource Produce();
    }
}