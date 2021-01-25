using System;
using PluginApp.Core;
using PluginApp.Core.PluginScopes;

namespace CountPlugin
{
    [Singleton]
    public class CountPlugin : IPlugin
    {
        public string Execute(string input) {
            return input.Length + "";
        }  
    }
}
