using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Command.Src
{
    public class Remote
    {
        private const int ButtonRowsCount = 7;
        private List<ICommand> onCommands;
        private List<ICommand> offCommands;
        public Remote()
        {
            onCommands = new List<ICommand>();
            offCommands = new List<ICommand>();
            var noCommand = new EmptyCommand();
            for(var i = 0; i < ButtonRowsCount; i++)
            {
                onCommands.Add(noCommand);
                offCommands.Add(noCommand);
            }
        }
        public void SetCommands(int number, ICommand onCommand, ICommand offCommand)
        {
            onCommands[number] = onCommand;
            offCommands[number] = offCommand;
        }
        public void OnButtonPressed(short number)
        {
            Console.WriteLine($"\n\n{number + 1} on button pressed");
            onCommands[number].Execute();
        }
        public void OffButtonPressed(short number)
        {
            Console.WriteLine($"\n\n{number + 1} off button pressed");
            offCommands[number].Execute();
        }
    }
}