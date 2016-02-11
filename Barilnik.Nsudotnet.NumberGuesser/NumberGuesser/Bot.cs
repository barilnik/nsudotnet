using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Bot
    {
        public const String THIS_IS_BIG_NUMBER = "Введенно число больше загаданного";
        public const String THIS_IS_SMALL_NUMBER = "Введенно число меньше загаданного";

        public static string[] swearing = { "Shut up, you div!", "is such a weirdo",
            "You’re a loser, I hate you", "What’s the matter, cat got your tongue?",
            "Get lost, I am tired of hearing from you." };

        public static int botNumber = 0;

        public void generateNumber()
        {
            Random random = new Random();
            botNumber = random.Next( 101 );
        }

/*        public bool checkEquallyNumbers( int humanNumber )
        {
            return botNumber.Equals( humanNumber );
        } */

        public String giveHint(  int humanNumber )
        {
            if( botNumber > humanNumber )
            {
                return THIS_IS_BIG_NUMBER;
            }
            else
            {
                return THIS_IS_SMALL_NUMBER;
            }
        }

        public String callNames()
        {        
            return swearing[ new Random().Next( 0, swearing.Length ) ];
        }
    }
}
