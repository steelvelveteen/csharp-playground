using System;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
           IElectronicDevice TV = TVRemote.GetDevice();
           PowerButton powBut = new PowerButton(TV);
           IElectronicDevice Radio = RadioRemote.GetDevice();
           PowerButton radioRemBut = new PowerButton(Radio);

           powBut.Execute();
           powBut.Undo();
           radioRemBut.Execute();
           radioRemBut.Undo();
        }
    }
}
