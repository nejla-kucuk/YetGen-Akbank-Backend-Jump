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
        private static ConfigurationService instance;

        public string GetValue(string key)
        {

            ConfigurationManager configurationManager = new();

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("Configuration.json");

            return configurationManager.GetSection(key).Value;
        }

        // Cons ile yeni instance oluşturulması engellendi.
        private ConfigurationService()
        {
            Console.WriteLine("Instance Created :)");
        }

        // "Static" keyword'u ile bu method çağrılarak instance oluşturulabilir.
        public static ConfigurationService GetInstance()
        {
            if(instance is null)
                instance = new ConfigurationService();


            return instance;
        }


    }
}
