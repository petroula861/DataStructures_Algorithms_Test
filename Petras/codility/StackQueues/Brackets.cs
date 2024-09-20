using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petras.codility.StackQueues
{
    public class Brackets
    {
        public int solution(string S)
        {
            var to_push = new HashSet<string>();
            to_push.Add("{");
            to_push.Add("[");
            to_push.Add("(");

            var matched = new Dictionary<string, string> { };
            matched["{"] = "}";
            matched["("] = ")";
            matched["["] = "]";

            Stack<string> stack = new Stack<string>();
            for (var i = 0; i < S.Length; i++)
            {
                if (to_push.Contains(S[i].ToString()))
                {
                    stack.Push(S[i].ToString());

                }
                else
                {

                    if (stack.Count == 0) return 0;
                    if ((!matched[stack.Pop()].Equals(S[i].ToString())))
                        return 0;
                }



            }
            if (stack.Count == 0) return 1;
            return 0;

        }
    }
}
