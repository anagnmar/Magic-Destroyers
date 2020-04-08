using System;
using MagicDestroyers.Characters.Melees;


namespace MagicDestroyers
{
    public class EntryPoint
    {
        static void Main()
        {

            warriorPlay goodGuy = new warriorPlay(10, 100, "Bob");
            warriorPlay badGuy = new warriorPlay(11, 70, "John");

            // field set with private access modifier, so can't be assigned any value
            // goodGuy.Damage = 20;

            goodGuy.Level = 200;
            Console.WriteLine(goodGuy.Level);

            Console.WriteLine();

            goodGuy.Attack(badGuy);
            badGuy.Attack(goodGuy);

            //Console.WriteLine();


            Console.ReadLine();
        }
    }

}



//Console.WriteLine($"{ }");