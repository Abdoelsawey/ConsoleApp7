using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> List = new LinkedList<string>();

            List.AddFirst("2");
            List.AddLast("6");
            LinkedListNode<String> Node = new LinkedListNode<string>("5");
            List.AddFirst(Node);
            List.AddBefore(Node, "9");
            List.AddAfter(Node, "8");

            Console.WriteLine("The LinkedList Before Reversing: ");

            foreach (var item in List)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("The LinkedList After Reversing: ");

            foreach (var item in List.Reverse())
            {
                Console.WriteLine(item);
            }

        }
    }
}
