using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedWord
{
    public class RepeatedWord
    {
        public static string RepeatableWord(string words)
        {
            if (words == null) return null;
            string[] wordArr = words.ToLower().Replace(",", "").Split(" ");

            HashSet<string> set = new HashSet<string>();
            foreach(string word in wordArr)
            {
                if (set.Contains(word))
                {
                    return word;
                }
                else
                {
                    set.Add(word);
                }
            }
            return null;
        }
    }
}
