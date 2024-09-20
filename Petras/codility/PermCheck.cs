using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class PermCheck
{
        public int solution(int[] A)
        {
            var sorted = A.OrderBy(x => x).Distinct().ToArray();

            if (sorted[0] == 1 && sorted.Length == A.Length
            && sorted[sorted.Length - 1] == sorted.Length)
                return 1;

            return 0;
        }
}