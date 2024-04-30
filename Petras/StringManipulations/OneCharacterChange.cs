using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.StringManipulations
{
    public class OneCharacterChange
    {
        public bool CheckOneAway(string s1, string s2)
        {
            int s1_length = s1.Count();
            int s2_length = s2.Count();

            if (s1_length == s2_length)
            {
                var s1_array1 = s1.ToArray();
                var s2_array1 = s2.ToArray();

                bool found_diff = false;
                for (int i = 0; i < s1_length; i++)
                {
                    

                    if (s1_array1[i] != s2_array1[i])
                    {

                        if (found_diff)
                            return false;

                        found_diff = true;

                    }
                }

                return true;//--accept same found_diff-not accepting same
            }

            var shortes_string = "";
            var longest_string = "";
            if (s1_length + 1 == s2_length || s2_length + 1 == s1_length)
            {
                if (s1_length > s2_length)
                {
                    shortes_string = s2;
                    longest_string = s1;

                }
                else {

                    shortes_string = s1;
                    longest_string = s2;
                }

                int index_shortstring = 0;
                int index_longstring=0;
                bool found_diff = false;
                while(index_shortstring< shortes_string.Length && index_longstring< longest_string.Length)
                {
                    if (shortes_string[index_shortstring] == longest_string[index_longstring])
                    {
                        index_shortstring++;
                        index_longstring++;
                    }
                    else {

                        if (found_diff)
                            return false;

                        found_diff=true;
                        index_longstring++;
                    }


                }

                return true;
            }

            return false;

        }

    }
}
