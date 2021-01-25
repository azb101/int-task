namespace PluginApp.Core.PluginDiscovery
{
    public interface IPluginResolver
    {
         IPlugin Resolve(string pluginName);
    }
}