using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Public
{
    public static class Config
    {
        /// <summary>
        /// tìm config file được chỉ định trên args dòng lệnh trước
        /// nếu không có trên dòng lệnh set là file cfg cùng thư mục
        /// chỉ trả về file name, không kiểm tra file tồn tại
        /// </summary>
        /// <returns></returns>
        public static string GetConfigFile()
        {
            const string cfg = "--config-file=";
            var args = Environment.GetCommandLineArgs();
            var arg = args.FirstOrDefault(a => a.StartsWith(cfg));
            if (arg is not null) return arg.RemoveQuote();
            return Constant.ExeFile + ".cfg";
        }

        /// <summary>
        /// tự tìm và load config, nếu không có thì sẽ trả về default (null)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T LoadConfig<T>() where T : new()
        {
            var file = GetConfigFile();
            if (!File.Exists(file)) return default;
            var json = File.ReadAllText(file);
            var obj = JsonSerializer.Deserialize<T>(json);
            return obj;
        }

        public static void SaveConfig(string file, object o)
        {
            var json = JsonSerializer.Serialize(o);
            File.WriteAllText(file, json);
        }
    }
}