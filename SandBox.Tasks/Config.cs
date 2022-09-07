﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Tasks
{
    public class Config
    {

        private IConfigurationRoot config;

        private string? _connectionString;
        public string ConnectionString
        {
            get {
                if (string.IsNullOrEmpty(_connectionString))
                    _connectionString = config.GetConnectionString("ArenaMySql").ToString();
                return _connectionString;
            }
        }

        public Config()
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile($"appsettings.json");

            this.config = configuration.Build();

        }
    }
}