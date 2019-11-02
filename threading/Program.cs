using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threading
{
    class Program
    {
        // Main method 
        static void Main(string[] args)
        {
            // Creating and initializing thread 
            Thread thr = new Thread(mythread);
            thr.Start();
            Console.WriteLine("Main Thread Ends!!");
            Console.ReadLine();
        }
        // Static method 
        static void mythread()
        {
            for (int c = 0; c <= 3; c++)
            {

                Console.WriteLine("mythread is in progress!!");
                Thread.Sleep(1000);
            }
            Console.WriteLine("mythread ends!!");
        }
    }
}
