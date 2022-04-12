using System;
using HeyLol;

namespace name_spaces
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHeyLol text = new SayHeyLol(); //hier maakt hij een nieuwe instantie aan van die class zodat je daar de functie uit kan halen
            text.SayHeyLmao(); // hier roept hij de functie van de sayheylol class aan
        }
    }
}

namespace HeyLol
{
    class SayHeyLol 
    {
        public void SayHeyLmao()
        {
            Console.WriteLine("Hey lol");
        }
    }
}
