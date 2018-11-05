namespace Command.Src
{
    public class CeilingFanOffCommand : CeilingFanCommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan) 
            : base(ceilingFan) {}
        
        protected override void ExecuteConcrete()
        {
            _ceilingFan.Off();
        }
    }
}