using System.Collections.Generic;
using System.Windows.Forms;

using E3PlugIn;

namespace e3PluginDemo.Helpers.Interfaces
{
    public interface IHelperControl
    {
        void RegisterControls(MainWindowInitEventArgs args, IEnumerable<UserControl> userControls);
    }
}
