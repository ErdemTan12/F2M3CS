using System;

namespace scopes
{
    internal class Program
    {

        public static void call()
        {
            {
                bool a = true;
                Console.WriteLine(a);
            }
        }
        static void Main(string[] args)
        {
            call();
        }
    }
}