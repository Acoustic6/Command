namespace Command.Src
{
    public class LightOnCommand : ICommand
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            _light = new Light();
        }
        public void Execute()
        {
            _light.SwitchOn();
        }
    }
}