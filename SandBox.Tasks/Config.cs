using Microsoft.Extensions.Configuration;
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

        public string? _missionId;
        public string MissionId
        {
            get
            {
                if (string.IsNullOrEmpty(_missionId))
                    _missionId = config.GetSection("MissionId").Value;

                return _missionId;
            }
        }
        public string? _savePath;
        public string SavePath
        {
            get
            {
                if (string.IsNullOrEmpty(_savePath))
                    _savePath = config.GetSection("SavePath").Value;

                return _savePath;
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
