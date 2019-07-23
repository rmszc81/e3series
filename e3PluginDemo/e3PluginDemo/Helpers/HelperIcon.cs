using System.Drawing;

namespace e3PluginDemo.Helpers
{
    using Interfaces;

    public class HelperIcon : IHelperIcon
    {
        public Icon Load(string path)
        {
            return new Icon(path);
        }
    }
}
