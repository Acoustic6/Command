using System;
using Command.Src;

namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var fan = new CeilingFan("Living Room");
            var highFanCommand = new CeilingFanHighCommand(fan);
            var lowFanCommand = new CeilingFanLowCommand(fan);
            var offFanCommand = new CeilingFanOffCommand(fan);
            var mediumFanCommand = new CeilingFanMediumCommand(fan);

            var remote = new Remote();
            remote.SetCommands(0, highFanCommand, offFanCommand);
            remote.SetCommands(1, mediumFanCommand, offFanCommand);
            remote.SetCommands(2, lowFanCommand, offFanCommand);

            remote.OnButtonPressed(1);
            remote.OffButtonPressed(1);
            remote.UndoButtonPressed();
            remote.OnButtonPressed(0);
            remote.UndoButtonPressed();
        }
    }
}
