using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10._0_DesingPattern
{
    public class ConfigurationService
    {
        public string GetValue(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("Configuration.json");

            return configurationManager.GetSection(key).Value;
        }
    }
}
