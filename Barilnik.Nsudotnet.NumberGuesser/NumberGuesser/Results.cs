using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Results
    {
        private int countAttempt = 1;
        private List< string > historyGame = new List< string >();

        public void increaseCurrentAttempt()
        {
            countAttempt++;
        }

        public void savedHistoryAttempt( string attempt )
        {
            historyGame.Add( attempt );
            Console.WriteLine(" Сохраненная аттемпта: " + attempt);
        } 

        public List<string> getHistory()
        {
            return historyGame;
        }

        public int getCountAttempt()
        {
            return countAttempt;
        }
    }
}
