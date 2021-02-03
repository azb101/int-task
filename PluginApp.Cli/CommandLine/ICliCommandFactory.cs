
using PluginApp.Cli.CommandLine.Commands;

namespace PluginApp.Cli.CommandLine
{
    public interface ICliCommandFactory
    {
        ICliCommand Create(string[] args);
    }
}