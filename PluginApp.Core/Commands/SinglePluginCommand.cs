namespace PluginApp.Core.Commands
{
    public class SinglePluginCommand : IPluginCommand
    {
        public IPlugin Plugin { get; private set; }
        public string Input {get; private set; }

        public SinglePluginCommand(IPlugin plugin, string input) {
            this.Plugin = plugin;
            this.Input = input;
        }

        public string Execute()
        {
            return Plugin.Execute(Input);
        }
    }
}