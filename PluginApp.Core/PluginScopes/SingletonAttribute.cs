using System;

namespace PluginApp.Core.PluginScopes {
 
    [AttributeUsage(AttributeTargets.Class)]
    public class SingletonAttribute : Attribute {}
    
}