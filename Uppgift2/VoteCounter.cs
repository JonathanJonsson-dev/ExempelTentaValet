using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift2
{
    public class VoteCounter
    {
        int[] chairs = new int[] { 70, 31, 20, 22, 100, 28, 16, 62 };

        public int CalculateMandate(bool[] checkedParties)
        {
            int sum = 0;
            for (int i = 0; i < checkedParties.Length; i++)
            {
                if (checkedParties[i] == true)
                {
                    sum += chairs[i];
                }
            }
            return sum;
        }

        public bool CheckMajority(int mandate)
        {
            if (mandate >= 175)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
