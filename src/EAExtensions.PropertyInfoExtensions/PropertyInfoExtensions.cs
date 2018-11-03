using System.Reflection;

namespace EAExtensions.PropertyInfoExtensions
{
    public static class PropertyInfoExtensions
    {
        public static bool IsNonStringEnumerable(this PropertyInfo pi)
        {
            //return pi != null && pi.PropertyType.IsNonStringEnumerable();
            return true;
        }
    }
}