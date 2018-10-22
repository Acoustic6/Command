namespace Command.Src
{
    public class LightOffCommand : ICommand
    {
        private Light _light;
        public LightOffCommand(Light light)
        {
            _light = new Light();
        }
        public void Execute()
        {
            _light.SwitchOff();
        }
    }
}