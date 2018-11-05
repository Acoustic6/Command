namespace Command.Src
{
    public class CeilingFanMediumCommand : CeilingFanCommand
    {
        public CeilingFanMediumCommand(CeilingFan ceilingFan) 
            : base(ceilingFan) {}
        
        protected override void ExecuteConcrete()
        {
            _ceilingFan.Medium();
        }
    }
}