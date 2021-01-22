﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node<T>
    {
        public T value { get; set; }
        public Node<T> next { get; set; }

        public Node(T value)
        {
            this.value = value;
        }
    }
}
