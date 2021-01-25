using System;
using PluginApp.Core;

namespace CountPlugin
{
    [SingletonAttribute]
    public class CountPlugin : IPlugin
    {
        public string Execute(string input) {
            return input.Length + "";
        }  
    }
}
