using System;
namespace laba4
{
    class Wind_instrument : Musical_instrument
    {
        public string Length_of_canal { set; get; }
        public override void sound()
        {

            Console.WriteLine("Phe-e-ew!");
        }


        public Wind_instrument(string manufacturer, string type, string model, string color, string owner, string CanalLenght) : base(manufacturer, type, model, color, owner)
        {
            Length_of_canal = CanalLenght;
            
        }
        public override string ToString()
        {
            return "Wind instrument: " + base.ToString() + $", length of canal: {Length_of_canal}.";
        }
    }
}
