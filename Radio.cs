using System;
namespace csharp_playground
{
    public class Radio : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("The radio is OFF");
        }

        public void On()
        {
            Console.WriteLine("The radio is ON");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The radio's volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine($"The radio's volume is at {Volume}");
        }
    }
}