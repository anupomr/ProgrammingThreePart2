using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(10);
            Console.WriteLine(n);

            LinkedList list = new LinkedList(20);
            list.AddAfterLast(30);
            list.Print();
            list.InsertBeforeFirst(55);
            list.Print();
            list.AddAfterLast(66);
            list.Print();
        }
    }
}
