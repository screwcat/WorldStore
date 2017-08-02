using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Common
{
    public class ConfigurationManag
    {
        public static Int32 ParkingCode = Convert.ToInt32(ConfigurationManager.AppSettings["ParkingCode"]);
        public static string PicFolder = ConfigurationManager.AppSettings["PicFolder"];
    }
}
