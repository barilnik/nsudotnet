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
        //public Hashtable history = new Hashtable();
        private Dictionary< int, string > history = new Dictionary< int, string >();

        public void increaseCurrentAttempt()
        {
            countAttempt++;
        }

        public void saveHistoryAttempt( int newNumber, string equally )
        {
            history.Add( newNumber, equally );
        }

        public IDictionary getHistory()
        {
            return history;
        }

        public int getCountAttempt()
        {
            return countAttempt;
        }
    }
}
