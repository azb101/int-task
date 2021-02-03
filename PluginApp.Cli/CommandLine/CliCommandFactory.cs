using System;
using System.Collections.Generic;
using System.Linq;
using PluginApp.Cli.CommandLine.Commands;
using PluginApp.Core.PluginDiscovery;

namespace PluginApp.Cli.CommandLine
{
    public class CliCommandFactory : ICliCommandFactory
    {
        private const string ListFlag = "-l";
        private const string RunFlag = "-r";
        private const string InputFlag = "-i";
        
        private readonly IPluginScanner pluginScanner;

        public CliCommandFactory(IPluginScanner pluginScanner)
        {
            this.pluginScanner = pluginScanner;
        }

        public ICliCommand Create(string[] args) {

            if (args == null)
                throw new ArgumentNullException(nameof(args));

            if(args[0] == ListFlag) {
                var plugins = pluginScanner.Scan();

                return new ListAllPluginsCommand(plugins.Keys.ToList());
            }

            if(args[0] == "run") {

                var pluginsToRun = new List<string>();
                var index = 1;
                while(index < args.Length && args[index] != InputFlag) {
                    pluginsToRun.Add(args[index++]);
                }

                if(index == args.Length-1) {
                    var input = args[index];

                    return new RunPluginCommand(pluginsToRun, args[index]);
                }
            }

            return new DummyCommand(string.Concat(args, ' '));
        }
    }
}