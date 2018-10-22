namespace Command.Src
{
    public class StereoWithCdOnCommand : ICommand
    {
        private StereoWithCd _stereo;
        public StereoWithCdOnCommand(StereoWithCd stereo)
        {
            _stereo = stereo;
        }
        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume();
        }        
    }
}