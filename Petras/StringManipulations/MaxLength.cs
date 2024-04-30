﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.StringManipulations
{
    public class MaxLength
    {
        //Maximum Length of a Concatenated String with Unique Characters
        public int MaxLengthConcatenatedString(IList<string> arr)
        {

            var max = 0;
            for (var i = 0; i < arr.Count; i++)
            {
                if (isUnique(arr[i]) && arr[i].Count() > max)
                    max = arr[i].Count();

                for (var j = i + 1; j < arr.Count(); j++)
                {
                    if (isUnique(arr[i] + arr[j]) && (arr[i] + arr[j]).Count() > max)
                        max = (arr[i] + arr[j]).Count();
                }
                
            }
            return max;
        }

        bool isUnique(string s)
        {

            System.Boolean[] bool_array = new System.Boolean[128];

            for (var i = 0; i < s.Count(); i++)
            {
                int index = s[i];
                if (bool_array[index])
                    return false;

                bool_array[index] = true;
            }
            return true;
        }

        //Input: arr = ["cha","r","act","ers"]
        //Output: 6
//Explanation: Possible longest valid concatenations are "chaers" ("cha" + "ers") and "acters" ("act" + "ers").
//Example 3:

//Input: arr = ["abcdefghijklmnopqrstuvwxyz"]
       // Output: 26
//Explanation: The only string in arr has all 26 characters.


    }
}
