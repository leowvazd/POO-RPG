namespace POO_RPG.src.Entities
{
    public class Opponent : Person
    {
        public Opponent(string name, int level, string personType, float life, float mana) : base(name, level, personType, life, mana)
        {
            this.name = name;
            this.level = level;
            this.personType = personType;
            this.life = life;
            this.mana = mana;
        }
    }
}