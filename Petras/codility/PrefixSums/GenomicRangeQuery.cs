using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.codility.PrefixSums
{
    public class GenomicRangeQuery
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            var A_prefix = new int[S.Length + 1];
            var C_prefix = new int[S.Length + 1];
            var G_prefix = new int[S.Length + 1];
            var T_prefix = new int[S.Length + 1];

            //prefix sum
            for (var i = 0; i < S.Length; i++)
            {
                A_prefix[i + 1] = A_prefix[i];
                C_prefix[i + 1] = C_prefix[i];
                G_prefix[i + 1] = G_prefix[i];
                T_prefix[i + 1] = T_prefix[i];


                switch (S[i])
                {
                    case ('A'):
                        A_prefix[i + 1] += 1;
                        break;
                    case ('C'):
                        C_prefix[i + 1] += 1;
                        break;
                    case ('G'):
                        G_prefix[i + 1] += 1;
                        break;
                    case ('T'):
                        T_prefix[i + 1] += 1;
                        break;
                }
            }

            var result = new int[P.Length];

            for (var i = 0; i < P.Length; i++)
            {
                if (A_prefix[Q[i] + 1] > A_prefix[P[i]])
                    result[i] = 1;
                else if (C_prefix[Q[i] + 1] > C_prefix[P[i]])
                {
                    result[i] = 2;
                }
                else if (G_prefix[Q[i] + 1] > G_prefix[P[i]])
                {
                    result[i] = 3;
                }
                else
                {
                    result[i] = 4;
                }
            }

            return result;

        }
    }
}
