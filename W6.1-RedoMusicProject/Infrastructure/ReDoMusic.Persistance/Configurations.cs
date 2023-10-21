﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Persistance
{
    public static class Configurations
    {

        public static string GetString(string key)
        {
            ConfigurationManager configurationManager = new();

            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName}\\Infrastructure\\ReDoMusic.Persistance";

            configurationManager.SetBasePath(path);

            configurationManager.AddJsonFile("PrivateInformation.json");

            return configurationManager.GetSection(key).Value;

        }
    }
}
