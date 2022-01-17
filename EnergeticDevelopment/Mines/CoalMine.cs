using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class CoalMine : Mine
    {
        public CoalMine() : base(MineType.Coal, ResourceType.Coal, 40) {}
    }
}