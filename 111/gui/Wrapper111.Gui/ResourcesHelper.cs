using System.Globalization;
using System.Resources;

namespace Wrapper111.Gui
{
    static class ResourcesHelper
    {
        static ResourceManager _rm = new ResourceManager("Wrapper111.Gui.Resources", typeof(ResourcesHelper).Assembly);

        public static string Get(string name)
        {
            try
            {
                return _rm.GetString(name, CultureInfo.CurrentUICulture) ?? name;
            }
            catch
            {
                return name;
            }
        }
    }
}
