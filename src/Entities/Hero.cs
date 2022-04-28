namespace dungeonDIO.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HealthPoints, int MagicPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
            this.MagicPoints = MagicPoints;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPoints;
        public int MagicPoints;

        public override string ToString()
        {
            return $"Name: {this.Name} \nLevel: {this.Level} \nType: {this.HeroType} \nHP: {this.HealthPoints} \nMP: {this.MagicPoints}\n";
        }

        public virtual string Attack()
        {
            return this.Name + " is attacking.";
        }
    }
}