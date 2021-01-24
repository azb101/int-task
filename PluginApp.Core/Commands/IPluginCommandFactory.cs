using System.Collections.Generic;

namespace PluginApp.Core.Commands
{
    public interface IPluginCommandFactory
    {
         IPluginCommand Create(string name, string input);
         IPluginCommand Create(List<string> names, string input);
    }
}