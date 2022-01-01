using System;
using POO_RPG.src.Entities;

namespace POO_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 42, "Knight.");
            Hero opponent = new Hero("Maleficus", 58, "Devil.");
            Wizard jenica = new Wizard("Jenica", 33, "White Wizard.");

            Console.WriteLine(arus);
            Console.WriteLine(jenica);
            Console.WriteLine(opponent);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jenica.Attack());
            Console.WriteLine(jenica.Attack(5));
        }
    }
}
