﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constellation
{
    public class PublicData
    {
        static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public string UserLocation = config.AppSettings.Settings["UserLocation"].Value;
        public string ColourScheme = config.AppSettings.Settings["ColourScheme"].Value;
        public string BoardOpened = config.AppSettings.Settings["BoardToOpen"].Value;
        public string UserDataLocaion = config.AppSettings.Settings["UserLoginLocation"].Value;


        private static string FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public string FileCreatePath = FolderPath + "\\Constellation";

    }
}
