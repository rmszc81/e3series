using System;

namespace e3PluginDemo.Helpers
{
    using Interfaces;

    public class HelperExtensions : IHelperExtensions
    {
        public Guid StringToGuid(string source)
        {
            var result = Guid.Empty;
            try
            {
                return Guid.Parse(source);
            }
            catch (Exception)
            {
                return result;
            }
        }
    }
}
