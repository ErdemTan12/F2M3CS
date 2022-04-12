using System;

namespace MyApplication
{
    class Rekenmachine
    {

        public void plus()
        {
            int x = 5;
            int y = 6;
            int plus = x + y;
            Console.WriteLine(plus);
        }
        public void keer()
        {
            int a = 5;
            int b = 6;
            int keer = a * b;
            Console.WriteLine(keer);
        }



        static void Main(string[] args)
        {
            Rekenmachine machine = new Rekenmachine();

            machine.plus();
            machine.keer();
        }
    }
}