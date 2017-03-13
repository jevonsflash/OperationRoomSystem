using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationRoomSystemPC.Common
{
    public class SideBarOnFinishedArg : EventArgs
    {

        public SideBarOnFinishedArg(object param, SideBarButtonType functionType)

        {

            this.Param = param;

            this.FunctionType = functionType;

        }

        public object Param { get; set; }

        public SideBarButtonType FunctionType { get; set; }

    }

    public enum SideBarButtonType

    {

        Import, Setting, Logout, Shutdown

    }
}
