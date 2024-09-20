using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.codility.PrefixSums
{
    public class MinAvg2Slice
    {
        public int solution(int[] A)
        {

            var prefix_sum = new int[A.Length];
            prefix_sum[0] = A[0];
            for (var i = 1; i < A.Length; i++)
            {
                prefix_sum[i] = prefix_sum[i - 1] + A[i];
            }

            var length2_min_value = double.MaxValue;
            var length2_index = 0;
            var sum = 0;
            //2 length
            for (var i = 0; i < prefix_sum.Length - 1; i++)
            {
                if (i == 0)
                {
                    length2_min_value = prefix_sum[i + 1];
                    length2_index = i;
                }
                else
                {
                    sum = prefix_sum[i + 1] - prefix_sum[i - 1];
                    if (length2_min_value > sum)
                    {
                        length2_min_value = sum;
                        length2_index = i;
                    }
                }
            }

            var length3_min_value = double.MaxValue;
            var length3_index = 0;
            sum = 0;
            //3 length
            for (var i = 0; i < prefix_sum.Length - 2; i++)
            {
                if (i == 0)
                {
                    length3_min_value = prefix_sum[i + 2];
                    length3_index = i;
                }
                else
                {
                    sum = prefix_sum[i + 2] - prefix_sum[i - 1];
                    if (length3_min_value > sum)
                    {
                        length3_min_value = sum;
                        length3_index = i;
                    }
                }
            }

            if (length3_min_value / 3 < length2_min_value / 2) return length3_index;

            return length2_index;
        }
    }
}
