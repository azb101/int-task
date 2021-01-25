using System;
using System.IO;
using PluginApp.Core.Commands;
using PluginApp.Core.PluginDiscovery;
using PluginApp.Core.PluginRunner;

namespace PluginApp.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var runner = new PluginRunner();
            var pluginScanner = new PluginScanner(buildDirectory("plugins"));
            var pluginResolver = new PluginResolver(pluginScanner);

            var commandFactory = new PluginCommandFactory(pluginResolver);

            //var command = commandFactory.Create("CountPlugin.CountPlugin", "aaabc");
            Console.WriteLine(runner.Run(commandFactory.Create("ReversePlugin.ReversePlugin", "aaabc")));
            Console.WriteLine(runner.Run(commandFactory.Create("ReversePlugin.ReversePlugin", "aaabc")));
        }

        private static string buildDirectory(string pluginsDirectory)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), pluginsDirectory);
        }
    }
}
