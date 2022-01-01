namespace POO_RPG.src.Entities
{
    public class Wizard : Hero
    {
        // Construtor
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        // Metodo
        public override string Attack()
        {
            return "\n" + this.name + " lançou magia.";
        }

        public string Attack(int Bonus)
        {
            return "\n" + this.name + " lançou magia com bônus de: +" + Bonus + ". ";
        }
    }
}