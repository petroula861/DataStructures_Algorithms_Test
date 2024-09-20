using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.Divisors
{
    public class CountDivisors
    {
        public int CountDivisorss(int n)
        {
            int count = 0;

            // Iterate over numbers from 1 to sqrt(n)
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0) // i is a divisor
                {
                    count++; // Count i as a divisor

                    // Check if n / i is also a divisor and different from i
                    if (i != n / i)
                    {
                        count++; // Count n / i as a divisor
                    }
                }
            }

            return count;
        }

    }
}
