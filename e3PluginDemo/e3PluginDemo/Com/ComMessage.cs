using e3;

namespace e3PluginDemo.Com
{
    using Interfaces;

    public class ComMessage : IComMessage
    {
        public void Show(string message)
        {
            using (var containerInterop = new ContainerInterop())
                containerInterop.Resolve<IApplicationInterface>().PutMessage(message);
        }
    }
}
