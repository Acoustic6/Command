namespace Command.Src
{
    public class StereoWithCdOffCommand : ICommand
    {
        private StereoWithCd _stereo;
        public StereoWithCdOffCommand(StereoWithCd stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.Off();
        }        

        public void Undo()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume();
        }
    }
}