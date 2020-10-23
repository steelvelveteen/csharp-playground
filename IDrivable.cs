namespace csharp_playground
{
    public interface IDrivable
    {
         int Wheels { get; set; }
         double Speed { get; set; }
         void Move();
         void Accelerate();
         void Stop();
    }
}