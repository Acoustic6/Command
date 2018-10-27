using System;
using Command.Src;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);

            var stereo = new StereoWithCd();
            var stereoOnCommand = new StereoWithCdOnCommand(stereo);
            var stereoOffCommand = new StereoWithCdOffCommand(stereo);

            var remote = new Remote();
            remote.SetCommands(0, lightOnCommand, lightOffCommand);
            remote.SetCommands(1, stereoOnCommand, stereoOffCommand);
            
            remote.OnButtonPressed(0);
            remote.UndoButtonPressed();
            remote.OnButtonPressed(1);
            remote.UndoButtonPressed();
        }
    }
}
