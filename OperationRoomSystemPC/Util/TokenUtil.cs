using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationRoomSystemPC.Util
{
    public class TokenUtil
    {
        static TokenUtil()
        {
            NavigationToken = "NAVIGATION_TOKEN";
            NavigationToken = "WINDOWN_TOKEN";
        }
        public static string NavigationToken { get; set; }
        public static string WindowToken { get; set; }  
    }
}
