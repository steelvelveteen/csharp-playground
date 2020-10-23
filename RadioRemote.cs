namespace csharp_playground
{
    public class RadioRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Radio();
        }
    }
}