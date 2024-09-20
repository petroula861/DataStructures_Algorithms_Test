using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.codility
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            var result = new int[N];
            var max_value = 0;
            var global_value = 0;
            for (var i = 0; i < A.Length; i++)
            {

                if (A[i] < N + 1)
                {
                    if(result[A[i] - 1]< global_value)
                    {
                        result[A[i] - 1] = global_value;

                    }
                    result[A[i] - 1]++;
                    max_value = result[A[i] - 1] > max_value ? result[A[i] - 1] : max_value;
                }
                else
                {
                    global_value = max_value;
                }

            }

            for (var j = 0; j < result.Length; j++)
            {
                if (result[j] < global_value)
                    result[j] = global_value;
            }
            return result;
        }


    }
}
