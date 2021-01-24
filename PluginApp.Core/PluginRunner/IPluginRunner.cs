using PluginApp.Core.Commands;

namespace PluginApp.Core.PluginRunner
{
    public interface IPluginRunner
    {
        string Run(IPluginCommand command);
    }
}