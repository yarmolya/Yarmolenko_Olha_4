using System;
namespace laba4
{
    class Keyboard_instrument : Musical_instrument
    {
        public bool Electrical { set; get; }
        public bool Transportable { set; get; }
        public override void sound()
        {
            Console.WriteLine("Peep!");
        }

        public Keyboard_instrument(string manufacturer, string type, string model, string color, string owner, bool electrical, bool transportable) : base(manufacturer, type, model, color, owner)
        {
            Electrical = electrical;
            Transportable = transportable;
            
    }
        public override string ToString()
        {
            return "Keyboard instrument: " + base.ToString() + $", electrical: {Electrical}, transportable: {Transportable}.";
        }
    }
}
