namespace Command.Src
{
    public class CeilingFanLowCommand : CeilingFanCommand
    {
        public CeilingFanLowCommand(CeilingFan ceilingFan) 
            : base(ceilingFan) {}
        
        protected override void ExecuteConcrete()
        {
            _ceilingFan.Low();
        }
    }
}