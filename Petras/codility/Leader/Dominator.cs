using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.codility.Leader
{
    public class Dominator
    {
        public int solution(int[] A)
        {

            if (A.Length == 0) return -1;
            var candidate = 0;
            var count = 0;

            for (var i = 0; i < A.Length; i++)
            {
                if (count == 0)
                    candidate = A[i];

                    count =+ candidate == A[i] ? 1 : -1;
            }

            var candidate_counter = 0;
            var candidate_index = 0;
            for (var i = 0; i < A.Length; i++)
            {

                if (A[i] == candidate)
                {
                    candidate_index = i;
                    candidate_counter++;
                }

            }

            //validate
            if (candidate_counter > A.Length / 2) return candidate_index;

            return -1;
        }

    }
}
