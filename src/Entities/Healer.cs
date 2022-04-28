namespace dungeonDIO.src.Entities
{
    public class Healer : Hero
    {
        public Healer(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints) : base(Name, Level, HeroType, HealthPoints, MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }

        public string Heal(Hero target)
        {
            if (this.MagicPoints >= 50)
            {
                target.HealthPoints += 20;
                this.MagicPoints -= 50;
                return $"{this.Name} healed 20HP from {target.Name} and it cost 50MP.\nNow {target.Name} has {target.HealthPoints}HP";
            }
            else
            {
                return "Not enough MP to cast the healing. You need at least 50 MP to cast it.";
            }

        }
    }
}