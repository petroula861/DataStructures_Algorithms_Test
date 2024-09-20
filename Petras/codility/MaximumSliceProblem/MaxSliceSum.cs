using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.codility.MaximumSliceProblem
{
    public class MaxSliceSum
    {
        public int solution(int[] A)
        {
            int res = A[0];
            int maxEnding = A[0];

            for (int i = 1; i < A.Length; i++)
            {

                // Find the maximum sum ending at index i by either extending 
                // the maximum sum subarray ending at index i - 1 or by
                // starting a new subarray from index i
                maxEnding = Math.Max(maxEnding + A[i], A[i]);

                // Update res if maximum subarray sum ending at index i > res
                res = Math.Max(res, maxEnding);
            }
            return res;
        }
    }
}
