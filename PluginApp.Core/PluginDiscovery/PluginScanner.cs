using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PluginApp.Core.PluginDiscovery
{
    public class PluginScanner : IPluginScanner
    {
        public Dictionary<string, Type> Scan(string path)
        {
            if (!Directory.Exists(path))
                throw new Exception("Invalid path");
            
            var plugins = new Dictionary<string, Type>();
            var targetType = typeof(IPlugin);

            foreach(var assemblyPath in Directory.GetFiles(path, "*.dll")) {
                var assembly = Assembly.LoadFile(assemblyPath);

                foreach(var type in assembly.GetTypes()) {
                    if(targetType.IsAssignableFrom(type)) {
                        plugins.Add(type.ToString(), type);
                    }
                }
            }            

            return plugins;
        }
    }
}