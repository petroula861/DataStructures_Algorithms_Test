using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Petras.StringManipulations
{
    public class Palindromes
    {
        public bool IsPermutationPalindromes(string s1)
        {

            //map characters to int
            int[] table= new int[(int)'z'- (int)'a'+1];
            var oddnumber = 0;

            foreach(char ch in s1)
            {
                var number = GetCharNumber(ch);
               if (number != -1)
                {
                    table[number]++;
                    //odd
                    if (table[number] % 2 == 1)
                    {
                        oddnumber++;
                    }
                    else
                    {
                        oddnumber--;

                    }

                }

            }
            return oddnumber <= 1;

        }
        public int GetCharNumber(char c)
        {
            if((int)'a' <= (int)c && (int)c <= (int)'z')
           return (int)c - (int)'a';

            return -1;
        }
    }
}
