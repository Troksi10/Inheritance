using System;

namespace Inheritance
{
     class TV : ElectricalDevice
    {
       public TV(bool isOn,string brand) : base(isOn,brand)
        {
           
        }

        public void WatchingTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV");
            }
            else
            {
                Console.WriteLine("TV is switched off,switch it on first");
            }
        }
    }
}
