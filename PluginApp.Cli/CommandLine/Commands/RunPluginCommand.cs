using System.Collections.Generic;

namespace PluginApp.Cli.CommandLine.Commands
{
    public class RunPluginCommand : ICliCommand
    {
        private readonly List<string> Plugins = new List<string>();
        private readonly string Input;
        
        public RunPluginCommand(List<string> plugins, string input) {
            this.Plugins = plugins;
            this.Input = input;
        }

        public void Execute()
        {
            
        }
    }
}