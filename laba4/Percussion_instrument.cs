using System;
namespace laba4
{
    class Percussion_instrument : Musical_instrument
    {
        public string Method { set; get; }
        public string Size { set; get; }
        public override void sound()
        {
            Console.WriteLine("Boom!");
        }

        public Percussion_instrument(string manufacturer, string type, string model, string color, string owner, string method, string size) : base(manufacturer, type, model, color, owner)
        {
            Method = method;
            Size = size;
           
    }
        public override string ToString()
        {
            return "Percussion instrument: " + base.ToString() + $", method of playing: {Method}, size: {Size}.";
        }
    }
}
