using System;
using System.Reflection;

namespace Otaku_Millionaire_Hot_Seat
{
    internal static class AppInfo
    {
        private static Assembly Assembly => typeof(AppInfo).Assembly;
        internal static string Title => Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;
        internal static string AssemblyName => Assembly.GetName().Name;
        internal static string ProductName => Assembly.GetCustomAttribute<AssemblyProductAttribute>().Product;
        internal static Version Version => Assembly.GetName().Version;
        internal static string Copyright => Assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
        internal static string CompanyName => Assembly.GetCustomAttribute<AssemblyCompanyAttribute>().Company;
        internal static string Description => Assembly.GetCustomAttribute<AssemblyDescriptionAttribute>().Description;
    }
}
