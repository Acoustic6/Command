namespace Command.Src
{
    public class PartyCommand : ICommand
    {
        private ICommand[] _commands = new ICommand[0];
        public PartyCommand(ICommand[] commands)
        {
            _commands = commands;
        }
        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }
}