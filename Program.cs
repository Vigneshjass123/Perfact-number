using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 28;
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (i % n == 0)
                {
                    count = count + i;
                }
            }
            if (count % n == 0)
            {
                Console.Write("this is perfact number is " + n);
            }
            else
            {
                Console.Write("this is  not perfact number is " + n);
            }
            Console.ReadLine();
        }
    }
}
        
