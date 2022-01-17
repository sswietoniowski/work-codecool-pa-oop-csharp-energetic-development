using System;

namespace EnergeticDevelopment.Mines
{
    public class MineFactory
    {
        public IMine Create(MineType mineType)
        {
            return mineType switch
            {
                MineType.Coal => new CoalMine(),
                MineType.Uranium => new UraniumMine(),
                MineType.Moon => new MoonMine(),
                MineType.HadronCollider => new HadronCollider(),
                _ => throw new ArgumentException($"Unsupported mine type: {mineType}")
            };
        }
    }
}