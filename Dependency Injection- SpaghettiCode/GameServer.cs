using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SpaghettiGameProject
{
    class GameServer
    {
        public CharacterClass characterclass;

        public void RegisterUser(string login, string password)
        {
            string LoginPattern = @"(?=.*[A-Za-z0-9]$)[A-Za-z][A-Za-z\d.-]{0,19}";
            string PasswordPattern = @"(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}";

            // Define a test string.        
            Match result1 = Regex.Match(login, LoginPattern);
            Match result2 = Regex.Match(password, PasswordPattern);

            if (result1.Success && result2.Success)
            {
                Console.WriteLine("Register user");
            }
            else
            {
                Console.WriteLine("Login or password are incorrect!");
            }
        }

        public void CreateCharacter(CharacterClass characterclass)
        {
            this.characterclass = characterclass;

            if (characterclass is Barbarian)
            {
                characterclass.Strength += 15;
                characterclass.Stamina += 9;

            }
            else if (characterclass is Paladin)
            {
                characterclass.Strength += 12;
                characterclass.Stamina += 8;

            }
            else if (characterclass is Mage)
            {
                characterclass.Strength += 7;
                characterclass.Stamina += 6;

            }
            else if (characterclass is Thief)
            {
                characterclass.Strength += 10;
                characterclass.Stamina += 10;
            }
        }

        public void StartGame()
        {
            // Start game
        }
    }
}
