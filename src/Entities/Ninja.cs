namespace POO_RPG.src.Entities
{
    public class Ninja : Person
    {
        public Ninja(string name, int level, string personType, float life, float mana) : base(name, level, personType, life, mana)
        {
            this.name = name;
            this.level = level;
            this.personType = personType;
            this.life = life;
            this.mana = mana;
        }
        public override string Attack()
        {
            return "\n" + this.name + " lançou uma shuriken.";
        }   
    }
}