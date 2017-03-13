using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;
using OperationRoomSystemPC.Common;
using OperationRoomSystemPC.Util;

namespace OperationRoomSystemPC.View
{
    /// <summary>
    /// LoginPage.xaml 的交互逻辑
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
          
        }

        private void SideBarControl_OnOnFinished(object sender, SideBarOnFinishedArg e)
        {
            if (e.FunctionType==SideBarButtonType.Setting)
            {
                var settingWindow=new SettingPage();
                settingWindow.ShowDialog();
            }
        }
    }
}
