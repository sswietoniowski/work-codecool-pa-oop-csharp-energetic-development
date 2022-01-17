using System;
using EnergeticDevelopment.Resources;

namespace EnergeticDevelopment.Mines
{
    public interface IPlant
    {
        Resource Consume();
        Resource Produce();
    }
}