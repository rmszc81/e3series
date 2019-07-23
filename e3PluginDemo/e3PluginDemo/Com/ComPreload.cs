using e3;

namespace e3PluginDemo.Com
{
    using Interfaces;

    public class ComPreload : IComPreload
    {
        private const string MessagePreload = "COM Interface was preloaded.";

        public void Run()
        {
            using (var containerInterop = new ContainerInterop())
            {
                var applicationInterface = containerInterop.Resolve<IApplicationInterface>();
                applicationInterface.PutMessage(MessagePreload);
            }
        }
    }
}
