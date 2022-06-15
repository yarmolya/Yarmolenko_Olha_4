using System;
using System.Collections.Generic;

namespace laba4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Musical_instrument> orchestra = new List<Musical_instrument>
            {
                new Wind_instrument("Yamaha", "Flute", "YFL-272", "silver with white", "Elizabeth", "37"),
                new String_instrument("Gibson", "Ukulele", "V-100", "brown", "Gabriel", 4, false),
                new Percussion_instrument("Kawai", "Bongo_drum", "FS-56", "dark brown", "Alex", "hands","small")
            };
            Orchestra.Write(orchestra);
            Console.WriteLine(" ");
            Console.WriteLine("Add a new instrument? [y/n]");
            string a = Console.ReadLine();
            if (a == "y")
            {
                Orchestra.AddInstr(orchestra);
                Console.WriteLine(" ");
                Orchestra.Write(orchestra);

            }
            Orchestra.PlayMusic(orchestra);
        }
    }
}
