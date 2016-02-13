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
      
            bool flag = true;
            Results results = new Results();

            while ( flag )
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if ( (results.getCountAttempt() % 4) == 0  )
                {
                    bot.callNames( username );
                }

                if ( !checkUserNumber( userNumber ) )
                {
                    Console.WriteLine( bot.giveHint( userNumber ) );

                    results.increaseCurrentAttempt();
                    results.savedHistoryAttempt( userNumber + " " + bot.giveHint( userNumber ) );
                    //results.saveHistoryAttempt(userNumber, bot.giveHint(userNumber));
                }
                else
                {
                    flag = false;
                    finish( results.getCountAttempt(), results.getHistory() );
                    Console.ReadLine();
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

        public static void finish( int countAttempt, List<string> historyGame )
        {
            Console.WriteLine("YOU WINS");
            Console.WriteLine("Your attempt: " + countAttempt );

            historyGame.ForEach(print);
            Console.WriteLine();
        }

        public static void print( string attempt )
        {
            Console.WriteLine( attempt );
        }
    }
}
