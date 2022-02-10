using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();


            queue.Enqueue(1);
            Console.WriteLine(queue.Count);
            queue.Enqueue(2);
            Console.WriteLine(queue.Count);
            queue.Enqueue(3);
            Console.WriteLine(queue.Count);
            queue.Enqueue(4);
            Console.WriteLine(queue.Count);
            queue.Dequeue();
            Console.WriteLine(queue.Count);
            queue.Peek();
            Console.WriteLine(queue.Count);


            Console.ReadKey();



        }
    }
}