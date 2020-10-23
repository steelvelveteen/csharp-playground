namespace csharp_playground
{
    public class PowerButton : ICommand
    {
        IElectronicDevice _device;
        public PowerButton(IElectronicDevice device)
        {
            _device = device;
        }
        public void Execute()
        {
            _device.On();
        }

        public void Undo()
        {
            _device.Off();
        }
    }
}