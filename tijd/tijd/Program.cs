using System;
using System.Globalization;
using System.Threading;

namespace tijd
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(1000);

            }
        }
    }
}
