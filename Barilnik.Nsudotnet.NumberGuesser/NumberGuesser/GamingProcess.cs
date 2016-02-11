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
        public static int userNumber = 0;

        static void Main(string[] args)
        {
            prepareGame();

            Bot bot = new Bot();
            bot.generateNumber();
            //Вывод на экран: отгадай число, которое я загадал

            userNumber = Console.Read();

            int countAttempt = 1;
            bool flag = true;

            while( flag )
            {
                if ( countAttempt.Equals( 4 ) )
                {
                    bot.callNames();
                }

                if ( !checkUserNumber( userNumber ) )
                {
                    bot.giveHint( userNumber );
                    countAttempt++;
                }
                else
                {
                    flag = false;
                    finish();
                }
            }
        }

        public static void prepareGame()
        {
            initNewUser();

            Console.WriteLine("Hi! I can play in game with you! Ha-ha-ha-ha...");
        }

        public static void initNewUser()
        {
            Console.WriteLine("Enter your name");
            username = Console.ReadLine();
        }

        public static bool checkUserNumber( int userNumber )
        {
            return userNumber.Equals(Bot.botNumber);
        }

        public static void finish()
        {
            Console.Write("YOU WINS");
        }
    }
}
