using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class N205_IsomorphicStrings : ILeetCodeExecute
    {

        public bool IsIsomorphic(string s, string t)
        {
            if(s == null || t == null || s.Length != t.Length) return false;

            Dictionary<char , char > dict = new Dictionary<char , char>();

            for (int i = 0; i < s.Length; i++)
            {
                bool isKeyExist = dict.ContainsKey(s[i]) ;
                if (isKeyExist && dict[s[i]] != t[i]) return false;
                else if (isKeyExist) continue;
                dict.Add(s[i], t[i]);
            }

            dict.Clear();

            for (int i = 0; i < t.Length; i++)
            {
                bool isKeyExist = dict.ContainsKey(t[i]);
                if (isKeyExist && dict[t[i]] != s[i]) return false;
                else if (isKeyExist) continue;
                dict.Add(t[i], s[i]);
            }
            return true;
        }
         
        public void Execute()
        {
            IsIsomorphic("paper", "title");
        }
    }
}
