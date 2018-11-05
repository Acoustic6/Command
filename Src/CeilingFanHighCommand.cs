namespace Command.Src
{
    public class CeilingFanHighCommand : CeilingFanCommand
    {
        public CeilingFanHighCommand(CeilingFan ceilingFan) 
            : base(ceilingFan) {}
        
        protected override void ExecuteConcrete()
        {
            _ceilingFan.High();
        }
    }
}