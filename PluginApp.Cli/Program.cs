using System;
using System.IO;
using PluginApp.Core.PluginDiscovery;

namespace PluginApp.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var pluginScanner = new PluginScanner();
            pluginScanner.Scan(Path.Combine(Directory.GetCurrentDirectory(), "plugins"));
        }
    }
}
