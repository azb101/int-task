using System;
using System.Collections.Generic;

namespace PluginApp.Core.PluginDiscovery
{
    public interface IPluginScanner
    {
        Dictionary<string, Type> Scan(string path);
    }
}