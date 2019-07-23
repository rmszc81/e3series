using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;

using e3;
using E3PlugIn;

namespace e3PluginDemo.Plugin
{
    using Com.Interfaces;
    using Helpers.Interfaces;
    using Interfaces;

    public class PluginMenu : IPluginMenu
    {
        private const string SubMenu = "Plugin Menu";
        private const string MenuItem01 = "Menu Item 01";
        private const string MenuItem02 = "Menu Item 02";
        private const string MenuItem03 = "Menu Item 03";
        private const string MenuItem04 = "This is menu is disabled";
        private const string MenuItem05 = "Show My Window";
        private const string Message = "The following menu item was clicked: ";

        private const string IconPath = @"Icons\";
        private const string IconName = "Icon.ico";
        private const string ControlId = "c07b1e1a-cebd-41c5-af22-72db0697838d";

        private readonly IComMessage _comMessage;
        private readonly IComWindow _comWindow;
        private readonly IHelperIcon _iconHelper;

        public PluginMenu(IHelperIcon iconHelper, IComMessage comMessage, IComWindow comWindow)
        {
            _iconHelper = iconHelper;
            _comMessage = comMessage;
            _comWindow = comWindow;
        }

        public void Create(IE3Menu menu)
        {
            var submenu = menu.Items.FirstOrDefault(m => m.Text == SubMenu);

            if (submenu == null)
                submenu = menu.InsertSubMenu(SubMenu, 0);

            submenu.InsertMenuItem(MenuItem01, () => _comMessage.Show($"{Message}{MenuItem01}"), submenu.Items.Count());
            submenu.InsertMenuItem(MenuItem02, () => _comMessage.Show($"{Message}{MenuItem02}"), submenu.Items.Count(), GetIcon());

            submenu.InsertSeparator(submenu.Items.Count());

            submenu.InsertMenuItem(MenuItem03, () => _comMessage.Show($"{Message}{MenuItem03}"), () => { return true; }, submenu.Items.Count());
            submenu.InsertMenuItem(MenuItem04, () => _comMessage.Show($"{Message}{MenuItem04}"), () => { return false; }, submenu.Items.Count(), GetIcon());
            submenu.InsertMenuItem(MenuItem05, () => _comWindow.ShowPluginWindow(ControlId), () => { return true; }, submenu.Items.Count(), GetIcon()); ;
        }

        private Icon GetIcon()
        {
            var assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return _iconHelper.Load(Path.Combine(assemblyFolder, IconPath, IconName));
        }
    }
}
