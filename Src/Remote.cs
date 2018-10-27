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
        private ICommand undoCommand;
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
            undoCommand = noCommand;
        }
        public void SetCommands(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void OnButtonPressed(short slot)
        {
            Console.WriteLine($"\n\n{slot + 1} on button pressed");
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }
        public void OffButtonPressed(short slot)
        {
            Console.WriteLine($"\n\n{slot + 1} off button pressed");
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonPressed()
        {
            Console.WriteLine("Undo button pressed");
            undoCommand.Undo();
        }
    }
}