using System.Collections.Generic;

namespace PluginApp.Core.PluginDiscovery
{
    public interface IPluginScanner
    {
        Dictionary<string, IPlugin> Scan(string path);
    }
}