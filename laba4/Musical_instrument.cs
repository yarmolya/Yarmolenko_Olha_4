using System;
namespace laba4
{
    class Musical_instrument
    {

        public string Manufacturer { set; get; }
        public string Type { set; get; }
        public string Model { set; get; }
        public string Color { set; get; }
        public string Owner { set; get; }
        public virtual void sound()
        {

            Console.WriteLine("music");
        }


        public Musical_instrument(string manufacturer, string type, string model, string color, string owner) 
        {
            Manufacturer = manufacturer;
            Type = type;
            Model = model;
            Color = color;
            Owner = owner;
            
           
        }

     
        public override string ToString()
        {
            string instrumentInfo = $"manufacturer: {Manufacturer}, type: {Type}, model: {Model}, color: {Color}, owner: {Owner}";

            return instrumentInfo;
        }
    }

   
}
