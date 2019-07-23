using e3;

namespace e3PluginDemo.Com
{
    using Interfaces;

    public class ComWindow : IComWindow
    {
        public void ShowPluginWindow(string controlId)
        {
            using (var containerInterop = new ContainerInterop())
                containerInterop.Resolve<IApplicationInterface>().ShowPluginWindow(1, controlId);
        }
    }
}
