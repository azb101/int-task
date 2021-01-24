namespace PluginApp.Core.PluginResolving
{
    public interface IPluginResolver
    {
         IPlugin Resolve(string pluginName);
    }
}