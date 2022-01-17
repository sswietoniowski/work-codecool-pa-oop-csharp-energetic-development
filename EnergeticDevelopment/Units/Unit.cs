namespace EnergeticDevelopment.Units
{
    public abstract class Unit : IUnit
    {
        public string Name { get; }

        public Unit(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}