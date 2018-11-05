using System;

namespace Command.Src
{
    public enum FanSpeed
    {
        Off,
        Low,
        Medium,
        High
    }
    public class CeilingFan
    {
        public FanSpeed Speed { get; set; }
        public string Location { get; set; }
        
        public CeilingFan(string location)
        { 
            Location = location;
            Speed = FanSpeed.Off;
        }

        public void High()
        {
            Speed = FanSpeed.High;
            Console.WriteLine("High speed on");
        }
        public void Medium()
        {
            Speed = FanSpeed.Medium;
            Console.WriteLine("Medium speed on");
        }
        public void Low()
        {
            Speed = FanSpeed.Low;
            Console.WriteLine("Low speed on");
        }
        public void Off()
        {
            Speed = FanSpeed.Off;
            Console.WriteLine("Fan is off");
        }
    }
}