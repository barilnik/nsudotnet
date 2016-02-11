using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class GamingProcess
    {
        public static String username;

        static void Main(string[] args)
        {
            initNewUser();

            Console.WriteLine("Hi! I can play in game with you! Ha-ha-ha-ha...");
            //Вывод на экран: отгадай число, которое я загадал
            Bot bot = new Bot();
            int botNumber = bot.generateNumber();
        }

        public static void initNewUser()
        {
            Console.WriteLine("Enter your name");
            username = Console.ReadLine();
        }

        public static bool checkUserNamber()
        {
            return true;
        }
    }
}
