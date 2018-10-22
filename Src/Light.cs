using System;

namespace Command.Src
{
    public class Light
    {
        public void SwitchOn() => Console.WriteLine("The light is on");
        public void SwitchOff() => Console.WriteLine("The light is off");
    }
}