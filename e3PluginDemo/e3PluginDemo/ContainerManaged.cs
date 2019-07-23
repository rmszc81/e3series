using System;

using Autofac;

namespace e3PluginDemo
{
    using Modules.Managed;

    public class ContainerManaged : IDisposable
    {
        private readonly IContainer Kernel;

        public ContainerManaged()
        {
            ContainerBuilder ContainerBuilder = new ContainerBuilder();
            ContainerBuilder.RegisterModule(new ModulePlugin());
            ContainerBuilder.RegisterModule(new ModuleCom());
            ContainerBuilder.RegisterModule(new ModuleHelper());
            ContainerBuilder.RegisterModule(new ModuleControls());
            Kernel = ContainerBuilder.Build();
        }

        public void Dispose()
        {
            Kernel.Dispose();
        }

        public TObject Resolve<TObject>() => Kernel.Resolve<TObject>();
    }
}
