using Autofac;

namespace e3PluginDemo.Modules.Managed
{
    using Com;
    using Com.Interfaces;

    public class ModuleCom : Module
    {
        protected override void Load(ContainerBuilder ContainerBuilder)
        {
            ContainerBuilder.RegisterType<ComMessage>().As<IComMessage>();
            ContainerBuilder.RegisterType<ComWindow>().As<IComWindow>();

            ContainerBuilder.RegisterType<ComBOM>().As<IComBOM>();
            ContainerBuilder.RegisterType<ComSheetText>().As<IComSheetText>();
            ContainerBuilder.RegisterType<ComProjectText>().As<IComProjectText>();
            ContainerBuilder.RegisterType<ComSheetHighlightSegment>().As<IComSheetHighlightSegment>();
            ContainerBuilder.RegisterType<ComPreload>().As<IComPreload>();
        }
    }
}
