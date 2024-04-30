using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.StringManipulations
{
    public class Permutations
    {
        public bool CheckPermutation(string s1, string s2)
        {

            var number_substrigs = s2.Count() - s1.Count();
            for (var i = 0; i < number_substrigs; i++)
            {

                   string s2_substring = s2.Substring(i, s1.Count());

                if (ArePremutations(s1, s2_substring))
                    return true;
            }
            return false;
        }

        public bool ArePremutations(string s3, string s4)
        {
            var test = s3.Order().ToArray();
            var test2=s4.Order().ToArray();
            for(var i=0;i<test.Count();i++)
            {
                if (test[i]!=test2[i])
                    return false;
            }
            return true;
        }
    }
}
