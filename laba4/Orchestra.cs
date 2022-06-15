using System;
using System.Collections.Generic;

namespace laba4
{
    class Orchestra
    {
        public static List<Musical_instrument> AddInstr(List<Musical_instrument> music)
        {
            string a = "boom";
            while (a != "x")
            {
                Console.WriteLine("Enter the type of instrument you want to add! To exit click [x]");
                a = Console.ReadLine();
                Console.WriteLine("Manufacturer: ");
                string man = Console.ReadLine();
                Console.WriteLine("Type: ");
                string type = Console.ReadLine();
                Console.WriteLine("Model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Color: ");
                string color = Console.ReadLine();
                Console.WriteLine("Owner: ");
                string owner = Console.ReadLine();

                if (a == "keyboard instrument")
                {
                    
                    Console.WriteLine("Electrical? [y/n] ");
                    string electr = Console.ReadLine();
                    bool el = false;
                    if (electr == "y")
                    {
                        el = true;
                    }
                    Console.WriteLine("Transportable? [y/n] ");
                    string trans = Console.ReadLine();
                    bool tr = false;
                    if (trans == "y")
                    {
                        tr = true;
                    }

                    Keyboard_instrument keyboard = new Keyboard_instrument(man, type, model, color, owner, el, tr);
                    music.Add(keyboard);
                }
                else if (a == "percussion instrument")
                {
                    
                    Console.WriteLine("Method of playing: ");
                    string method = Console.ReadLine();
                    Console.WriteLine("Size: ");
                    string size = Console.ReadLine();
                    Percussion_instrument percussion = new Percussion_instrument(man, type, model, color, owner, method, size);
                    music.Add(percussion);
                }
                else if (a == "string instrument")
                {
                    
                    Console.WriteLine("Number of strings: ");
                    int strings = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Electrical? [y/n] ");
                    string electr = Console.ReadLine();
                    bool el = false;
                    if (electr == "y")
                    {
                        el = true;
                    }
                    String_instrument str = new String_instrument(man, type, model, color, owner, strings, el);
                    music.Add(str);
                }
                else if (a == "wind instrument")
                {
                    
                    Console.WriteLine("Length of canal: ");
                    string length = Console.ReadLine();

                    Wind_instrument wind = new Wind_instrument(man, type, model, color, owner, length);
                    music.Add(wind);
                }
                
            }
            return music;
        }

        public static void PlayMusic(List<Musical_instrument> music)
        {
            Console.WriteLine("Do you want to play some music? [y/n]");
            string a = Console.ReadLine();
            if (a == "y")
            {
                foreach (Musical_instrument i in music)
                {

                    i.sound();

                }
            }
            if (a == "n")
            {
                Console.WriteLine("*silence*");
            }
        }

        public static void Write(List<Musical_instrument> music)
        {
            int count = 1;
            Console.WriteLine("Orchestra: ");
            foreach (Musical_instrument i in music)
            {
                Console.Write("{0})", count);
                Console.WriteLine(i);
                count++;
            }
        }
    }

    
}