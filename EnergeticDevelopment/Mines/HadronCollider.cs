using EnergeticDevelopment.Resources;
using EnergeticDevelopment.Units;

namespace EnergeticDevelopment.Mines
{
    public class HadronCollider : Mine
    {
        public HadronCollider() : base(MineType.HadronCollider, ResourceType.Antimatter, 1 / 7.0) {}
    }
}