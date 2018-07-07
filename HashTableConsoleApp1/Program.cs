using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid","1001");
            ht.Add("Name", "Anupom Roy");
            ht.Add("Job","Manager");
            ht.Add("Salary","80000");
            ht.Add("Phone","6477047186");
            ht.Add("Email","anupomr@gmail.com");
            ht.Add("Locatio", "anupomr@gmail.com");
            Console.WriteLine(ht["Email"]);
        }
    }
}
