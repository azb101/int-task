using System.Collections.Generic;

namespace PluginApp.Cli.CommandLine.Commands
{
    public class ListAllPluginsCommand : ICliCommand
    {
        private readonly List<string> plugins;

        public ListAllPluginsCommand(List<string> plugins)
        {
            this.plugins = plugins;
        }

        public void Execute()
        {
            foreach(var plugin in plugins) {
                System.Console.WriteLine(plugin);
            }
        }
    }
}