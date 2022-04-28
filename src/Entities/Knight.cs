namespace dungeonDIO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base(Name, Level, HeroType, HealthPoints, MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }

        public override string Attack()
        {
            return this.Name + " is attacking with the sword.";
        }
    }
}