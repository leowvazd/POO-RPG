using System;
using POO_RPG.src.Entities;

namespace POO_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight ("Arus", 42, "Knight", 469, 72);
            WhiteWizard jenica = new WhiteWizard ("Jenica", 33, "White Wizard", 325, 474);
            Ninja wedge = new Ninja ("Wedge", 42, "Ninja", 292, 89);
            BlackWizard topapa = new BlackWizard ("Topapa", 45, "Black Wizard", 106, 611);
            Opponent tutu = new Opponent("Tutu", 99, "Devil", 5000, 4000);

            Console.WriteLine(arus);
            Console.WriteLine(jenica);
            Console.WriteLine(wedge);
            Console.WriteLine(topapa);
            Console.WriteLine(tutu);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jenica.Attack());
            Console.WriteLine(jenica.Attack(1));
            Console.WriteLine(jenica.Attack(7));
            Console.WriteLine(wedge.Attack());
            Console.WriteLine(topapa.Attack());
            Console.WriteLine(topapa.Attack(3));
            Console.WriteLine(topapa.Attack(10));
        }
    }
}
