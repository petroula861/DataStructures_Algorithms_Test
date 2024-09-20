using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.codility
{

    //given an array A of N integers
    //returns the smallest Positive Integer greater than 0
    //that doesnt occur in A
    public class MissingInteger
    {
            public int solution(int[] A)
            {
                var array_sorted = A.Order().ToArray();
                int min_int = 1;

                for (int i = 0; i < array_sorted.Count(); i++)
                {
                    if (array_sorted[i] > 0)
                    {
                        if (array_sorted[i] == min_int)
                            min_int++;
                        if (min_int < array_sorted[i]) return min_int;
                    }

                }

                return min_int;
        }

    }
}
