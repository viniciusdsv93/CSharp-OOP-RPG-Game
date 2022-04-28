using System;
using dungeonDIO.src.Entities;

namespace dungeonDIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight", 100, 50);
            Wizard wizard = new Wizard("Jenica", 50, "Wizard", 100, 200);
            Archer leggie = new Archer("Leggie", 47, "Archer", 100, 120);
            Healer magnus = new Healer("Magnus", 32, "Healer", 60, 250);

            Console.WriteLine(arus.ToString());
            Console.WriteLine(wizard.ToString());
            Console.WriteLine(leggie.ToString());
            Console.WriteLine(magnus.ToString());
            Console.WriteLine();
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(20));
            Console.WriteLine(leggie.StrongAttack());
            Console.WriteLine(magnus.Heal(leggie));
            Console.WriteLine();
            Console.WriteLine(arus.ToString());
            Console.WriteLine(wizard.ToString());
            Console.WriteLine(leggie.ToString());
            Console.WriteLine(magnus.ToString());
        }
    }
}
