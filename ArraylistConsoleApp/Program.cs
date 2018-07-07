using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraylistConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Now Array Capacity : " + al.Capacity);
            al.Add(100);
            Console.WriteLine("Now Array Capacity : " + al.Capacity);
            al.Add(200); al.Add(300); al.Add(400);
            Console.WriteLine("Now Array Capacity : " + al.Capacity);
            al.Add(500);
            Console.WriteLine("Now Array Capacity : " + al.Capacity);
            Console.Write("Now Array is       : " );
            foreach (object item in al)
            {
                Console.Write($"{item},  ");
            }
            Console.WriteLine();//"Adding value into Array"
            al.Insert(3, 350);
            Console.Write("Now Array is       : ");foreach (object item in al) Console.Write($"{item},  ");
            Console.WriteLine();
            al.Remove(200);
            al.RemoveAt(3);


            Console.WriteLine();
        }
    }
}
