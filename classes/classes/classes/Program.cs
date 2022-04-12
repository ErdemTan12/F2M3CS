using System;

namespace classes
{
    class RekenMachine
    {
        public void plus()
        {
            Console.WriteLine("gimme dem numbers im gonna add em together >:)");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int plus = getal1 + getal2;

            Console.WriteLine(getal1 + "+" + getal2 + "=" + plus);
        }
        public void min()
        {
            Console.WriteLine("gimme dem numbers im gonna unadd em together >:)");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int min = getal1 - getal2;

            Console.WriteLine(getal1 + "-" + getal2 + "=" + min);
        }

        public void keer()
        {
            Console.WriteLine("gimme dem numbers im gonna multiply em >:)");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int keer = getal1 * getal2;

            Console.WriteLine(getal1 + "x" + getal2 + "=" + keer);
        }
        public void delen()
        {
            Console.WriteLine("gimme dem numbers im gonna divide em >:)");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int delen = getal1 / getal2;

            Console.WriteLine(getal1 + ":" + getal2 + "=" + delen);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RekenMachine machine = new RekenMachine();

            machine.plus();
            machine.min();
            machine.keer();
            machine.delen();
        }
    }
}
