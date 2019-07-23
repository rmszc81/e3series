using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using Autofac;

namespace e3PluginDemo.Modules.Managed
{
    public class ModuleControls : Autofac.Module
    {
        protected override void Load(ContainerBuilder ContainerBuilder)
        {
            var userControlDerivedTypes = Assembly.GetExecutingAssembly()
                                                  .GetTypes()
                                                  .Where(type => type != typeof(UserControl) && typeof(UserControl).IsAssignableFrom(type))
                                                  .ToArray();

            ContainerBuilder.RegisterTypes(userControlDerivedTypes).As<UserControl>();
        }
    }
}

