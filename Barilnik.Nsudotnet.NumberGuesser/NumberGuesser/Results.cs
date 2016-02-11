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
        private int attempt = 0;
        //public Hashtable history = new Hashtable();
        private Dictionary< int, string > history = new Dictionary< int, string >();

        private void increaseCurrentAttempt()
        {
            attempt++;
        }

        private void saveHistoryAttempt( int newNumber, string equally )
        {
            history.Add( newNumber, equally );
        }

        public IDictionary getHistory()
        {
            return history;
        }
    }
}
