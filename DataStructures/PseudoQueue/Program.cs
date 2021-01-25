using System;
using System.Collections.Generic;
using System.Text;

namespace PseudoQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PseudoQueu<int> pq = new PseudoQueu<int>();
            pq.Enqueue(15);
            pq.Enqueue(12);
            pq.Enqueue(11);

            Console.WriteLine(pq.Dequeue());
        }
    }
}
