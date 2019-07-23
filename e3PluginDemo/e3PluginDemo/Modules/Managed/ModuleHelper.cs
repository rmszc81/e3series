using Autofac;

namespace e3PluginDemo.Modules.Managed
{
    using Helpers;
    using Helpers.Interfaces;

    public class ModuleHelper : Module
    {
        protected override void Load(ContainerBuilder ContainerBuilder)
        {
            ContainerBuilder.RegisterType<HelperControl>().As<IHelperControl>();
            ContainerBuilder.RegisterType<HelperExtensions>().As<IHelperExtensions>();
            ContainerBuilder.RegisterType<HelperIcon>().As<IHelperIcon>();
        }
    }
}
