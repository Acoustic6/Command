using System;
using Command.Src;

namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var stereo = new StereoWithCd();
            var stereoOnCommand = new StereoWithCdOnCommand(stereo);
            var stereoOffCommand = new StereoWithCdOffCommand(stereo);
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);

            var partyOnCommands = new ICommand[] 
            {
                lightOnCommand,
                stereoOnCommand,
            };

            var partyOnCommand = new PartyCommand(partyOnCommands);

            var partyOffCommands = new ICommand[] 
            {
                lightOffCommand,
                stereoOffCommand,
            };

            var partyOffCommand = new PartyCommand(partyOffCommands);

            var remote = new Remote();

            remote.SetCommands(0, partyOnCommand, partyOffCommand);

            remote.OnButtonPressed(0);
            remote.OffButtonPressed(0);
        }
    }
}
