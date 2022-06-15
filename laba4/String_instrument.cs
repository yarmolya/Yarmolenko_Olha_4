using System;
namespace laba4
{
    class String_instrument : Musical_instrument
    {
        public int Number_of_strings { set; get; }
        public bool Electrical { set; get; }
        public override void sound()
        {
            Console.WriteLine("Brin-n!");
        }

            public String_instrument(string manufacturer, string type, string model, string color, string owner, int NumOfStrings, bool electrical) : base(manufacturer, type, model, color, owner)
        {
            Number_of_strings = NumOfStrings;
            Electrical = electrical;
            
    }
        public override string ToString()
        {
            return "String instrument: " + base.ToString() + $", number of strings: {Number_of_strings}, electrical: {Electrical}.";
        }
    }
}
