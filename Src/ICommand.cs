namespace Command.Src
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}