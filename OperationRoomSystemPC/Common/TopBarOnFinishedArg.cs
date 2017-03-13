using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationRoomSystemPC.Common
{

    public class TopBarOnFinishedArg : EventArgs
    {

        public TopBarOnFinishedArg(object param, TopBarButtonType functionType)

        {

            this.Param = param;

            this.FunctionType = functionType;

        }

        public object Param { get; set; }

        public TopBarButtonType FunctionType { get; set; }

    }

    public enum TopBarButtonType

    {

        Back, Home, Refresh, Minimize, Shortcut

    }

}
