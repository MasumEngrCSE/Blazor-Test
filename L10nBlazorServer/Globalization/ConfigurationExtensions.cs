﻿//using Microsoft.AspNetCore.Localization;
//using System.Configuration;

using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
//L10nBlazorServer.Globalization
namespace L10nBlazorServer.Globalization
{
    public static class ConfigurationExtensions
    {
        public static Dictionary<string, string> GetCulturesSection
                    (this IConfiguration configuration) => configuration
            .GetSection("Cultures")
            .GetChildren()
            .ToDictionary(k => k.Key, v => v.Value);


    }



}
