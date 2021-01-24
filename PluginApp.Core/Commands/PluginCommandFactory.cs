using System.Collections.Generic;
using PluginApp.Core.PluginDiscovery;

namespace PluginApp.Core.Commands
{
    public class PluginCommandFactory : IPluginCommandFactory
    {
        private readonly IPluginScanner pluginScanner;

        public IPluginCommand Create(string name, string input)
        {
            // resolve plugins
            return new SinglePluginCommand(null, null);
        }

        public IPluginCommand Create(List<string> names, string input)
        {
            // resolve all plugins
            throw new System.NotImplementedException();
        }
    }
}