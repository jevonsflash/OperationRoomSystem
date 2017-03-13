using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationRoomSystemPC.Common
{

    public class NavigationArg
    {
        public NavigationArg(Type type)
        {
            this.PageType = type;
        }
        public NavigationArg(Type type, string param)
        {
            this.Param = param;
            this.PageType = type;
        }
        public Type PageType { get; set; }

        public string Param { get; set; }
    }
}
