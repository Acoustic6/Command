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
    }
}