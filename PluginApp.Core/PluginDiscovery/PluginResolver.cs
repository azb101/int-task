using System;
using System.Collections.Generic;
using System.Linq;
using PluginApp.Core.PluginScopes;

namespace PluginApp.Core.PluginDiscovery
{
    public class PluginResolver : IPluginResolver
    {
        private readonly Dictionary<Type, IPlugin> SingletonContainer = new Dictionary<Type, IPlugin>();

        private readonly IPluginScanner pluginScanner;

        public PluginResolver(IPluginScanner pluginScanner) {
            this.pluginScanner = pluginScanner;
        }

        public IPlugin Resolve(string pluginName)
        {
            var plugins = pluginScanner.Scan();
            if(!plugins.ContainsKey(pluginName))
                throw new System.Exception($"Plugin {pluginName} is not found or not registered");
            
            return activatePluginWithProperScope(plugins[pluginName]);
        }

        private IPlugin activatePluginWithProperScope(Type pluginType) {
            
            if(isSingleton(pluginType)) {
                if (SingletonContainer.ContainsKey(pluginType)) {
                    return SingletonContainer[pluginType];
                }

                var newSingletonPlugin = (IPlugin)Activator.CreateInstance(pluginType);
                SingletonContainer[pluginType] = newSingletonPlugin;
                return newSingletonPlugin;
            }

            return (IPlugin)Activator.CreateInstance(pluginType);
        }

        private bool isSingleton(Type type) {
            foreach(var attribute in type.GetCustomAttributes(true)) {
                if(attribute is SingletonAttribute) {
                    return true;
                }
            }
            
            return false;
        }
    }
}