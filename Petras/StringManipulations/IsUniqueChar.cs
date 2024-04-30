using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.StringManipulations
{
    public class IsUniqueChar
    {
        //determine if a string has all unique characters O(n^2)
        //public bool isAllUnique(string input)
        //{
        //    var list = new HashSet<char>();
        //    foreach (char c in input)
        //    {
        //        if (list.Contains(c))
        //            return false;

        //        list.Add(c);
        //    }
        //    return true;

        //}


        // O(n) if we know exact character length 128 ascii, extended 256
        public bool isAllUnique(string input)
        {
            if (input.Length > 128)
                return false;

            Boolean[] bools = new Boolean[128];

            for(int i = 0; i<input.Length;i++)
            {
                int value = input[i];
                if(bools[value])
                    return false;

                bools[value] = true;

            }
            return true;

        }
        //return first unique else -1
        public int FirstUniqChar(string s)
        {
            int length = s.Length;
            String str;
            for (int i = 0; i < length; i++)
            {
                if (i == length - 1)
                {
                    str = s.Substring(0, i);
                }
                else
                {
                    str = s.Substring(0, i) + s.Substring(i + 1);
                }
                if (!str.Contains(s[i] + ""))
                    return i;
            }
            return -1;
        }

    }


}
