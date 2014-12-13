using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnqueueConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> aQueue = new Queue<int>();
            aQueue.Enqueue(100);
            aQueue.Enqueue(200);
            aQueue.Enqueue(150);
            foreach (int number in aQueue)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
