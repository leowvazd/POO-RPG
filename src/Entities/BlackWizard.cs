namespace POO_RPG.src.Entities
{
    public class BlackWizard : Person
    {
        // Construtor
        public BlackWizard(string name, int level, string personType, float life, float mana) : base(name, level, personType, life, mana)
        {
            this.name = name;
            this.level = level;
            this.personType = personType;
            this.life = life;
            this.mana = mana;
        }

        // Metodo
        public override string Attack()
        {
            return "\n" + this.name + " lançou magia.";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return "\n" + this.name + " lançou uma super magia negra com bônus de: +" + Bonus + ". ";
            }

            else
            {
                return "\n" + this.name + " lançou uma magia negra com bônus de: +" + Bonus + ". ";
            }
        }
    }
}