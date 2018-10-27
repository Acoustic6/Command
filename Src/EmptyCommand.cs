using System;

namespace Command.Src
{
    public class EmptyCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No command");
        }
        public void Undo()
        {
            Console.WriteLine("No command");
        }
    }
}