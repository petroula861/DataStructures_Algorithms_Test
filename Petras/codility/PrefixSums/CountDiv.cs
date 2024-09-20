using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Petras.codility.PrefixSums
{
    public class CountDiv
    {
        //        Write a function:

        //class Solution { public int solution(int A, int B, int K); }

        //        that, given three integers A, B and K, returns the number of integers within the range[A..B] that are divisible by K, i.e.:

        //{ i : A ≤ i ≤ B, i mod K = 0 }

        //    For example, for A = 6, B = 11 and K = 2, your function should return 3, because there are three numbers divisible by 2 within the range[6..11], namely 6, 8 and 10.

        //Write an efficient algorithm for the following assumptions:

        //A and B are integers within the range[0..2, 000, 000, 000];
        //    K is an integer within the range[1..2, 000, 000, 000];
        //A ≤ B.
        public int solution(int A, int B, int K)
        {
            var count = 0;
            var init_v = A / K;
            var last_v = B / K;
            if (init_v != last_v && (int)last_v == (int)init_v)
                return 0;

            count = (int)B / K - (int)A / K;

            return A % K == 0 ? count + 1 : count;

        }

    }
}
