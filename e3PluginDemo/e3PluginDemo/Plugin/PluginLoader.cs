using System;
using System.Collections.Generic;
using System.Windows.Forms;

using E3PlugIn;

namespace e3PluginDemo.Plugin
{
    using Com.Interfaces;
    using Helpers.Interfaces;
    using Plugin.Interfaces;

    public class PluginLoader : IE3PlugIn, IDisposable
    {
        private readonly ContainerManaged _containerManaged;

        public PluginLoader()
        {
            _containerManaged = new ContainerManaged();
        }

        public void Dispose()
        {
            _containerManaged.Dispose();
        }

        public void Init(IE3InitializationContext context)
        {
            context.RegisterMainWindowInitEventHandler((sender, args) =>
            {
                var userControls = _containerManaged.Resolve<IEnumerable<UserControl>>();

                _containerManaged.Resolve<IHelperControl>().RegisterControls(args, userControls);
                _containerManaged.Resolve<IPluginMenu>().Create(args.MainMenu);
                _containerManaged.Resolve<IComPreload>().Run();
            });
        }
    }
}
