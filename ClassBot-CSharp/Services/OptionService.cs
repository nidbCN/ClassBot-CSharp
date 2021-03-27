using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ClassBot_CSharp.Models;

namespace ClassBot_CSharp.Services
{
    public class OptionService : IOptionService
    {
        public AppConfig GetConfig(string path = "Config.json")
        {
            path ??= "Config.json";

            return JsonSerializer.Deserialize<AppConfig>(GetFileContent(path));
        }

        private static string GetFileContent(string path)
            => File.ReadAllText(path);
    }
}
