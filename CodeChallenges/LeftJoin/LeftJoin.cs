using System;
using System.Collections.Generic;
using System.Text;

namespace LeftJoin
{
    public class LeftJoin
    {
        public static List<string> leftJoin(Dictionary<string, string> synonyms, Dictionary<string, string> antonyms)
        {
            List<string> arrayOfHashMaps = new List<string>();

            foreach(string n in synonyms.Keys)
            {
                if (synonyms.ContainsKey(n))
                {
                    var item1 = synonyms.TryGetValue(n, out string value) ? value : "null";
                    var item2 = antonyms.TryGetValue(n, out string value2) ? value2 : "null";
                    arrayOfHashMaps.Add(n + ": " + item1 + ", " + item2);
                }
                else
                {
                    var item = synonyms.TryGetValue(n, out string value) ? value : "null";
                    arrayOfHashMaps.Add(n + ": " + item + ", " + null);
                }
            }
            return arrayOfHashMaps;
        }
    }
}
