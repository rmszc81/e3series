using Autofac;

namespace e3PluginDemo.Modules.Managed
{
    using Plugin;
    using Plugin.Interfaces;

    public class ModulePlugin : Module
    {
        protected override void Load(ContainerBuilder ContainerBuilder)
        {
            ContainerBuilder.RegisterType<PluginMenu>().As<IPluginMenu>();
        }
    }
}
