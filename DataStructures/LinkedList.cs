using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList
    {
        private Node last;

        public LinkedList(int data)
        {
            last = new Node(data);
        }
        public void Print()
        {
            StringBuilder result = new StringBuilder();
            if (!this.IsEmpty())
            {
                Node current = last;
                do
                {
                    result.Append(current.ToString() + " ");
                    current = current.Next;

                } while (current != null);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("the queue is empty");
            }
        }
    

        public void AddAfterLast(int data)
        {
            Node oldLast = last;
            last = new Node(data);
            last.Next = oldLast;
        }
        public void InsertBeforeFirst(int data)
        {
            Node current = last;
            while (current.Next != null)
            {
                current = current.Next;
            }
            //now we are at the first node
            current.Next = new Node(data);
        }
        public void Delete(int value)
        {
            Node previous = last;
            do
            {
                if (previous.Next.Data == value)
                {
                    previous.Next = previous.Next.Next;
                    return;
                }
                previous = previous.Next;
            } while (previous.Next != null);
        }
        public void Delete(Node other)
        {
            Node previous = last;
            do
            {
                if (previous.Next.Data == other.Data)
                {
                    previous.Next = previous.Next.Next;
                    return;
                }
                previous = previous.Next;
            } while (previous.Next != null);
        }
        public void RemoveFirst()
        {
            if (IsEmpty())
                return;

            Node toKeep = last.Next;
            Node current = last;
            while (current.Next != null)
            {
                toKeep = current;
                current = current.Next;
            }
            //now we are at the first node
            toKeep.Next = null;
        }
        public void Count() {
            int result = 1;
            Node toKeep = last.Next;
            Node current = last;

            // output current node data while not at end of list
            while (current.Next != null)
            {
                result++;
                toKeep = current;
                current = current.Next;

            }
            Console.WriteLine("Total = "+result);
        }
        public void Sum()
        {
            int result = 0;
            Node toKeep = last.Next;
            Node current = last;
            result += current.Data;
            // output current node data while not at end of list
            while (current.Next != null)
            {
                result+=current.Next.Data;
                toKeep = current;
                current = current.Next;


            } 
            Console.WriteLine("Sum = " + result);
        }
        public void Search(int newData)
        {
           
            Node toKeep = last.Next;
            Node current = last;
           
            // output current node data while not at end of list
            while (current.Next != null)
            {
               
                toKeep = current;
                if (current.Data == newData)
                { Console.WriteLine("Data found !!"); }
                current = current.Next;
            }
           
        }
        public bool IsEmpty() => last == null;
        public void RemoveLast()
        {
            throw new NotImplementedException();
        }

    }

}
