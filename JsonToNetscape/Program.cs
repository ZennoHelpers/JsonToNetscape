using JsonToNetscape;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace JsonToNetscape
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(@"Need argument with JSON file path");
                return;
            }
            if (!File.Exists(args[0]))
            {
                Console.WriteLine(@"File does not exist, path " + args[0]);
                return;
            }

            var path = args[0];
            var json = File.ReadAllText(path);
            var cd = Path.GetDirectoryName(path);
            if(string.IsNullOrEmpty(cd)) throw new Exception("Не удалось получить имя папки");
            
            var convertPath = Path.Combine(cd, Path.GetFileNameWithoutExtension(path) + "_converted.txt");

            var result = CookieConv.ToNetscape(json);

            Console.WriteLine(@"Json converted to netscape, result path " + convertPath);

            File.WriteAllText(convertPath, result);
        }
    }
}
