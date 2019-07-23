using System;

using Autofac;

namespace e3PluginDemo
{
    using Modules.Interop;

    public class ContainerInterop : IDisposable
    {
        private readonly IContainer Kernel;

        public ContainerInterop()
        {
            ContainerBuilder ContainerBuilder = new ContainerBuilder();
            ContainerBuilder.RegisterModule(new ModuleCom());
            Kernel = ContainerBuilder.Build();
        }

        public void Dispose()
        {
            Kernel.Dispose();
        }

        public TObject Resolve<TObject>() => Kernel.Resolve<TObject>();
    }
}
