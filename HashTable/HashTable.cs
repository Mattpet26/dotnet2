using System;
using System.Text;
using DataStructures;

namespace DataStructures
{
    public class Hashtable
    {
        private LinkedList<KeyValuePair<string, string>>[] Map { get; set; }
        public Hashtable(int size)
        {
            Map = new LinkedList<KeyValuePair<string, string>>[size];
        }

        public int Hash(string key)
        {
            LinkedList<string> list = new LinkedList<string>();
            int HashValue = 0;
            char[] letters = key.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                HashValue += letters[i];
            }
            HashValue = (HashValue * 599) % Map.Length;
            return HashValue;
        }

        public void Add(string key, string value)
        {
            int index = Hash(key);
            if (Map[index] == null)
            {
                Map[index] = new LinkedList<KeyValuePair<string, string>>();
            }
            KeyValuePair<string, string> pairs = new KeyValuePair<string, string>(key, value);
            Map[index].AddFirst(pairs);
        }

        public string Get(string key)
        {
            int index = Hash(key);
            var current = Map[index].First;
            while (current != null)
            {
                if (current.Value.Value == key)
                {
                    return current.Value.Value;
                }
                current = current.Next;
            }
            return default;
        }

        public bool Contains(string key)
        {
            int index = Hash(key);
            if (Map[index] != null)
            {
                var current = Map[index].First;
                while (current != null)
                {
                    if (current.Value.Value == key)
                    {
                        return true;
                    }
                    current = current.Next;
                }
            }
            return false;
        }
    }
}

