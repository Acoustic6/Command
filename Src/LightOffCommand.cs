namespace Command.Src
{
    public class LightOffCommand : ICommand
    {
        private Light _light;
        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.SwitchOff();
        }

        public void Undo()
        {
            _light.SwitchOn();
        }
    }
}