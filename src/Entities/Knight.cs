namespace POO_RPG.src.Entities
{
    public class Knight : Person
    {
    public Knight(string name, int level, string personType, float life, float mana) : base(name, level, personType, life, mana)
        {
            this.name = name;
            this.level = level;
            this.personType = personType;
            this.life = life;
            this.mana = mana;
        }        
    }
}