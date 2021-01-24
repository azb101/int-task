using System;
using PluginApp.Core.Commands;

namespace PluginApp.Core.PluginRunner
{
    public class PluginRunner : IPluginRunner
    {   
        public string Run(IPluginCommand command)
        {
            if(command == null)
                throw new ArgumentNullException(nameof(command));

            return command.Execute();
        }
    }
}