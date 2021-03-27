using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassBot_CSharp.Models;

namespace ClassBot_CSharp.Services
{
    public interface IOptionService
    {
        public AppConfig GetConfig(string path = "Config.json");
    }
}
