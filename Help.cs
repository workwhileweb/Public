using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace Public
{
    public static class Help
    {
        public static string Now()
        {
            return DateTime.Now.ToString("yyMMddhhmmss");
        }

        public static string RemoveQuote(this string source)
        {
            source = source?.Trim();
            if (source == null) return null;
            while (source.StartsWith("\"") && source.EndsWith("\""))
                source = source.Substring(1,source.Length-2).Trim();
            return source;
        }

        public static string GetEnvStr()
        {
            return JsonSerializer.Serialize(GetEnvironment());
        }

        public static Dictionary<string, string> GetEnvironment()
        {
            var result = new Dictionary<string, string>();
            var proc = Process.GetCurrentProcess();
            result.Add(nameof(proc.MainModule.FileName), proc.MainModule?.FileName);
            result.Add(nameof(proc.ProcessName), proc.ProcessName);
            result.Add(nameof(proc.Id), proc.Id.ToString());
            result.Add(nameof(proc.SessionId), proc.SessionId.ToString());
            result.Add(nameof(Environment.CommandLine), Environment.CommandLine);
            var args = string.Join(Constant.Spliter, Environment.GetCommandLineArgs());
            result.Add(nameof(Environment.GetCommandLineArgs), args);
            foreach (DictionaryEntry variable in Environment.GetEnvironmentVariables())
                result.Add("env-" + (string)variable.Key, (string)variable.Value);
            return result;
        }

    }
}