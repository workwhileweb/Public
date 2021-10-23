using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Public
{
    public static class InOut
    {
        /// <summary>
        ///     https://docs.microsoft.com/en-us/dotnet/standard/io/how-to-copy-directories
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        /// <param name="excludeNames"></param>
        /// <param name="copySubDirs"></param>
        /// <param name="overwrite"></param>
        public static void DirectoryCopy(
            string sourceDirName,
            string destDirName,
            IList<string> excludeNames = null,
            bool copySubDirs = true,
            bool overwrite = true)
        {
            var dir = new DirectoryInfo(sourceDirName);
            if (!dir.Exists) throw new DirectoryNotFoundException(sourceDirName);
            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);
            // Get the files in the directory and copy them to the new location.
            var files = dir.GetFiles().Where(f => !excludeNames?.Contains(f.Name) ?? true);
            foreach (var file in files)
            {
                var tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, overwrite);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (!copySubDirs) return;
            var dirs = dir.GetDirectories().Where(f => !excludeNames?.Contains(f.Name) ?? true);
            foreach (var subdir in dirs)
            {
                var tempPath = Path.Combine(destDirName, subdir.Name);
                var excludes = excludeNames?
                    .Where(name =>
                        name.Length > subdir.Name.Length + 1 &&
                        name.StartsWith(subdir.Name) &&
                        (name[subdir.Name.Length] == '\\' || name[subdir.Name.Length] == '/'))
                    .Select(name => name.Substring(subdir.Name.Length + 1)).ToList();
                DirectoryCopy(subdir.FullName, tempPath, excludes, true, overwrite);
            }
        }
    }
}