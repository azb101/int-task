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
            var plugins = pluginScanner.Scan(Path.Combine(Directory.GetCurrentDirectory(), "plugins"));

            foreach(var plug in plugins) {
                var activatedPlugin = (Core.IPlugin)Activator.CreateInstance(plug.Value);
                Console.WriteLine(activatedPlugin.Execute("abc"));
            }
        }
    }
}
