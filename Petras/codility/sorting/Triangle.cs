using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.codility.sorting
{
    public class Triangle
    {
        public int solution(int[] A)
        {
            if (A.Length < 3)
                return 0;

            var sorted_array = A.OrderBy(x => x).ToArray();

            for (var i = 0; i < sorted_array.Length - 2; i++)
            {
                if ((long)sorted_array[i] + sorted_array[i + 1] > sorted_array[i + 2])
                    return 1;
            }

            return 0;
        }

    }
}
