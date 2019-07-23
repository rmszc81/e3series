using System.Collections.Generic;
using System.Windows.Forms;

using E3PlugIn;

namespace e3PluginDemo.Helpers
{
    using Interfaces;

    public class HelperControl : IHelperControl
    {
        private readonly IHelperExtensions _helperExtensions;
        public HelperControl(IHelperExtensions helperExtensions)
        {
            _helperExtensions = helperExtensions;
        }

        public void RegisterControls(MainWindowInitEventArgs args, IEnumerable<UserControl> userControls)
        {
            foreach (var userControl in userControls)
                args.AddDockingWindow(userControl.Name, userControl, _helperExtensions.StringToGuid(userControl.Tag.ToString()));
        }
    }
}
