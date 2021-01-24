using System.Collections.Generic;

namespace PluginApp.Core.PluginResolving
{
    public class PluginResolver : IPluginResolver
    {
        Dictionary<string, IPlugin> container = new Dictionary<string, IPlugin>();

        public PluginResolver() {

        }

        public IPlugin Resolve(string pluginName)
        {
            
            throw new System.NotImplementedException();
        }
    }
}