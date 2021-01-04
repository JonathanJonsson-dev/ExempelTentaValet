using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift1
{
    public class VoteCounter
    {
        public char ElectionWinner(int alternativeA, int alternativeB, int alternativeC)
        {
            if (alternativeA > alternativeB && alternativeA > alternativeC)
            {
                return 'A'; // snuffar '' används vid char och "" vid strängar
            }
            else if (alternativeB > alternativeA && alternativeB > alternativeC)
            {
                return 'B';
            }
            else if (alternativeC > alternativeA && alternativeC > alternativeB)
            {
                return 'C';
            }
            else
            {
                return 'X';
            }
        }
    }
}
