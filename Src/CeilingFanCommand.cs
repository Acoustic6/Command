using System;

namespace Command.Src
{
    public abstract class CeilingFanCommand : ICommand
    {
        protected CeilingFan _ceilingFan;
        protected FanSpeed _prevSpeed;
        public CeilingFanCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
            _prevSpeed = FanSpeed.Off;
        }
        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            ExecuteConcrete();
        }

        public void Undo()
        {
            switch(_prevSpeed)
            {
                case FanSpeed.High:
                    _ceilingFan.High();
                    break;
                case FanSpeed.Medium:
                    _ceilingFan.Medium();
                    break;
                case FanSpeed.Low:
                    _ceilingFan.Low();
                    break;
                case FanSpeed.Off:
                    _ceilingFan.Off();
                    break;
            }
        }
        protected abstract void ExecuteConcrete();
    }
}