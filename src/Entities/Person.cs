namespace POO_RPG.src.Entities
{
    public  abstract class Person
    {
        // Atributos
        public string name, personType;
        public int level;
        public float life, mana;     

        // Construtor
        public Person(string name, int level, string personType, float life, float mana)
        {
            this.name = name;
            this.level = level;
            this.personType = personType;
            this.life = life;
            this.mana = mana;
        }

        // Metodos
        public override string ToString()
        {
            return "\n" + this.name + ", level " + this.level + " and type " + this.personType + ". HP: " + this.life + ". MP: " + this.mana + ".\n";
        }
        
        public virtual string Attack()
        {
            return "\n" + this.name + " atacou com a sua espada.";
        }
    }
}