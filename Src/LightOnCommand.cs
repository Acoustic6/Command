namespace Command.Src
{
    public class LightOnCommand : ICommand
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.SwitchOn();
        }

        public void Undo()
        {
            _light.SwitchOff();
        }
    }
}