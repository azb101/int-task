using System.Collections.Generic;

namespace PluginApp.Core.Commands
{
    public class MultiplePluginCommand: IPluginCommand
    {
        public List<IPlugin> Plugins {get; private set; }
        public string Input { get; private set; }

        public MultiplePluginCommand(List<IPlugin> plugins, string input) {
            this.Plugins = plugins;
            this.Input = input;
        }

        public string Execute()
        {
            string currentInput = Input;
            foreach(var plugin in Plugins) {
                currentInput = plugin.Execute(currentInput);
            }

            return currentInput;
        }
    }
}