using CofeMaster.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CofeMaster.ConfigFolder.ClassFolder
{
    internal class UppDataInfo_Class
    {
        public string currentVersion_UDIC = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public string DateLastUpdate_UDIC = Settings.Default.DateLastUpdate;
    }
}
