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
            prepareGame();

            Bot bot = new Bot();
            bot.generateNumber();
            //Вывод на экран: отгадай число, которое я загадал

            int countAttempt = 1;
            bool flag = true;

            while( flag )
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Attempt = " + countAttempt);

                if ( (countAttempt % 4) == 0  )
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
            return userNumber == Bot.botNumber;
        }

        public static void finish()
        {
            Console.Write("YOU WINS");
        }
    }
}
