using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node
    {
        public int value { get; set; }
        public Node next { get; set; }

        public Node(int value)
        {
            this.value = value;
        }
    }
}
