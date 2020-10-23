using System;
namespace csharp_playground
{
    public class Television : IElectronicDevice
    {
        public int Volume { get; set; }
        public void Off()
        {
            Console.WriteLine("The TV is OFF");
        }

        public void On()
        {
            Console.WriteLine("The TV is ON");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine($"The TV's volume is at {Volume}");
        }

        public void VolumeUp()
        {
            if (Volume !=100) Volume++;
            Console.WriteLine($"The TV's volume is at {Volume}");
        }
    }
}