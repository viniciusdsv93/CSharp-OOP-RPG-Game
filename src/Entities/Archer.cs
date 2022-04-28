namespace dungeonDIO.src.Entities
{
    public class Archer : Hero
    {
        public Archer(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base(Name, Level, HeroType, HealthPoints, MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }

        public override string Attack()
        {
            return $"{this.Name} is firing an normal arrow.";
        }

        public string StrongAttack()
        {
            if (this.MagicPoints >= 50)
            {
                this.MagicPoints -= 50;
                return $"{this.Name} is firing super effective flamming arrows.";
            }
            else
            {
                return "Not enough MP points to cast the attack. You need at least 50 MP to cast it.";
            }
        }
    }
}