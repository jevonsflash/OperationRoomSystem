using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Messaging;
using OperationRoomSystemPC.Common;
using OperationRoomSystemPC.Util;
using OperationRoomSystemPC.View;

namespace OperationRoomSystemPC
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Messenger.Default.Register<NavigationArg>(this, TokenUtil.NavigationToken, HandleNavigationResult);
            Messenger.Default.Register<string>(this, TokenUtil.WindowToken, HandleWindowResult);

        }

        private void HandleWindowResult(string obj)
        {
            var mainWindow = App.Current.MainWindow;

            switch (obj as string)
            {
                case "minimize":

                    mainWindow.WindowState = WindowState.Minimized;

                    break;
                case "close":
                    mainWindow.Close();

                    break;
            }
        }

        private void HandleNavigationResult(NavigationArg obj)
        {
            var mainWindow = App.Current.MainWindow;

            var window = mainWindow as MainWindow;
            if (window != null)
            {

                var page = window.MainFrame.NavigationService.Content as Page;

                //比较当前页面与试图跳转页面是否相同
                if (page != null && page.GetType() != obj.PageType)
                {
                    (mainWindow as MainWindow).MainFrame.NavigationService.Navigate(Activator.CreateInstance(obj.PageType));
                }
            }
        }
    }
}
