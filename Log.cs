using System;
using System.IO;
using System.Text.Json;

namespace Public
{
    public static class Log
    {
        public static readonly string Folder = Path.Combine(Constant.DataFolder, "Log");
        public static readonly string File = Path.Combine(Folder, Help.Now());

        /// <summary>
        /// //TODO : loại bỏ call init ở đầu hàm main mà vẫn handle được exception
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public static void Init()
        {
            var currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += CurrentDomainUnhandledException;

            if (!Directory.Exists(Folder)) 
                Directory.CreateDirectory(Folder);
            Message(Help.GetEnvStr());
        }

        public static void Message(params string[] msgs)
        {
            var msg = string.Join(Constant.Spliter, msgs);
            var line = string.Concat(Help.Now(), Constant.Spliter, msg, Environment.NewLine);
            Console.Write(line);
            System.IO.File.AppendAllText(File, line);
        }

        public static void Fatal(Exception e)
        {
            Log.Message(JsonSerializer.Serialize(e));
            Environment.Exit(1);
        }

        private static void CurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Fatal(e.ExceptionObject as Exception);
        }
    }
}