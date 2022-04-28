namespace dungeonDIO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base(Name, Level, HeroType, HealthPoints, MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }

        public override string Attack()
        {
            return this.Name + " is attacking with magic.";
        }

        public string Attack(int Bonus)
        {
            if (this.MagicPoints >= 10)
            {
                this.MagicPoints -= 10;
                if (Bonus > 6)
                {
                    return this.Name + " is attacking super effectively with a bonus of " + Bonus;
                }
                else
                {
                    return this.Name + " is attacking with a bonus of " + Bonus;
                }
            }
            else
            {
                return "Not enough MP to cast the attack. You need at least 10 MP to cast it.";
            }


        }
    }
}