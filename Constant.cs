using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace Public
{
    public static class Constant
    {
        public const string Spliter = "->";

        public static readonly Assembly ExeAsm = Assembly.GetExecutingAssembly();
        public static readonly string ExeFile = Process.GetCurrentProcess().MainModule?.FileName ?? ExeAsm.Location;
        public static readonly string ExeFolder = Path.GetDirectoryName(ExeFile);
        public static readonly string DataFolder = Path.Combine(ExeFolder, "Data");
    }
}