namespace csharp_playground
{
    public interface ICommand
    {
        void Execute();
        void Undo(); 
    }
}