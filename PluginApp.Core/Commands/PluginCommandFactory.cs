using System.Collections.Generic;
using System.Linq;
using PluginApp.Core.PluginDiscovery;

namespace PluginApp.Core.Commands
{
    public class PluginCommandFactory : IPluginCommandFactory
    {
        private readonly IPluginResolver pluginResolver;

        public PluginCommandFactory(IPluginResolver pluginResolver)
        {
            this.pluginResolver = pluginResolver;
        }

        public IPluginCommand Create(string name, string input)
        {
            var plugin = pluginResolver.Resolve(name);
            if(plugin == null)
                throw new System.Exception($"Plugin {name} does not exists");

            return new SinglePluginCommand(plugin, input);
        }

        public IPluginCommand Create(List<string> names, string input)
        {
            var plugins = names.Select(pluginName => pluginResolver.Resolve(pluginName)).ToList();
            
            return new MultiplePluginCommand(plugins, input);
        }
    }
}