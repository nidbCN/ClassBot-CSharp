using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBot_CSharp.Services
{
    public interface IGroupService
    {
        public Task GetClassesTable(int? week = null);
        public Task GetWeather(string[] location);
        
    }
}
