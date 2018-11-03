using EAExtensions.TypeExtensions;
using System.Reflection;

namespace EAExtensions
{
    public static class Extensions
    {
        public static bool IsNonStringEnumerable(this PropertyInfo pi)
        {
            return pi != null && pi.PropertyType.IsNonStringEnumerable();
        }
    }
}