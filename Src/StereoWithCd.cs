using System;

namespace Command.Src
{
    public class StereoWithCd
    {
        public void Off() => Console.WriteLine("stereo off");
        public void On() => Console.WriteLine("stereo on");
        public void SetCd() => Console.WriteLine("stereo setted cd");
        public void SetDVD() => Console.WriteLine("stereo setted dvd");
        public void SetRadio() => Console.WriteLine("stereo turned radio");
        public void SetVolume() => Console.WriteLine("stereo setted volume");
    }
}