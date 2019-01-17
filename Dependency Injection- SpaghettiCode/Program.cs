using System;
using System.Text.RegularExpressions;

namespace SpaghettiGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameServer gameserver = new GameServer();

            gameserver.RegisterUser("assd12", "adasd123@");

            gameserver.CreateCharacter(new Barbarian());

            Console.WriteLine("Skill points after give out");

            Console.WriteLine(gameserver.characterclass.Strength);
            Console.WriteLine(gameserver.characterclass.Stamina);

            Console.ReadKey();
        }
    }
}
