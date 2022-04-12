using System;

namespace getters_en_setters
{
    class Program
    {
        static void Main(string[] args)
        {
            pizza pizza = new pizza(); //je pakt hier de name variable
            Console.WriteLine(pizza.GetName()); 
            pizza.SetName("uvuvwevwevwe onyetenyevwe ugwemubwem ossas"); //met setname veranderd hij de naam
            Console.WriteLine(pizza.GetName());
        }
    }

    internal class pizza
    {
        private string name = "kkwazzawazzakkwaquikkwalaquaza zzabolazza"; //hier maakt ie stringf aan

        internal void SetName(string NewName) //de functie maakt van de naam newname
        {
            name = NewName;
        }
        internal string GetName() //deze funcite returnded zo hard
        {
            return name;
        }
    }
}
