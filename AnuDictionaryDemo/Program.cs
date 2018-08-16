using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnuDictionaryDemo
{
    class Program
    {
       static int[] intArray = new int[7];
         static Random rnd1 = new Random();
        static void Main(string[] args)
        {
            //Console.WriteLine(RandomNunber(2));
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    intArray[i] = RandomNunber(1,2);
            //    Console.WriteLine(intArray[i]);
            //}
            int count = 0;
            Console.WriteLine(RacNunber(11,ref count));
            int total = RacNunber(5, ref count);
            Console.WriteLine("count"+ count);
            Console.WriteLine("total" + total);
        }
        static int RacNunber(int num,ref int count)//recursion
        {
            count++;
            if (count >= 10)
                return count;
            // intArray[num] = rnd1.Next(num);
            //return RacNunber(rnd1.Next(num, max));
            return RacNunber(num+1,ref count);
        }
        static void MultiNunber(int num)//recursion
        {
            // if (num < 2) return 1;
            //Console.WriteLine( MultiNunber(num-1) *2));
        }
    }
}
