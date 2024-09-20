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

        public int FirstUniqChar2(string s)
        {
            string tmp_str = s;

            while(tmp_str.Length>0)
            {
                if (tmp_str.Length == 1) return s.IndexOf(tmp_str[0]);

                char first_char= tmp_str[0];
                string sb_string= tmp_str.Substring(1);

                if (sb_string.Contains(first_char))
                {
                    var index_remove = sb_string.IndexOf(first_char);
                    while (sb_string.IndexOf(first_char) != -1)
                    {
                        sb_string = sb_string.Substring(0, index_remove)+ sb_string.Substring(index_remove + 1);

                       
                    };


                    tmp_str = sb_string;
                }
                else
                    return s.IndexOf(first_char);
            }

            return -1;
        }
    }


}
