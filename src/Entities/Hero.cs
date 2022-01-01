namespace POO_RPG.src.Entities
{
    public class Hero
    {
        // Atributos
        public string name;
        public int level;
        public string heroType;

        // Construtor
        public Hero(string name, int level, string heroType)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
        }

        // Metodos
        public override string ToString()
        {
            return "\n" + this.name + ", level " + this.level + " and type " + this.heroType + "\n";
        }

        public virtual string Attack()
        {
            return "\n" + this.name + " atacou com a sua espada.";
        }
    }
}