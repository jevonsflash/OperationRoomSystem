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
using OperationRoomSystemPC.View;

namespace OperationRoomSystemPC.Control
{
    /// <summary>
    /// SideBarControl.xaml 的交互逻辑
    /// </summary>
    public partial class SideBarControl : UserControl
    {
        public event EventHandler<SideBarOnFinishedArg> OnFinished;

        public SideBarControl()
        {
            InitializeComponent();
        }

        public static DependencyProperty ShowParamProperty =
    DependencyProperty.Register("ShowParam", typeof(string), typeof(SideBarControl), new FrameworkPropertyMetadata("import,setting,logout,shutdown", ShowParamPropertyChanged));

        private static void ShowParamPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as SideBarControl;

            control.ImportButton.Visibility = Visibility.Collapsed;
            control.SettingButton.Visibility = Visibility.Collapsed;
            control.LogoutButton.Visibility = Visibility.Collapsed;
            control.ShutdownButton.Visibility = Visibility.Collapsed;
            if (control != null)
            {
                var isnull = string.IsNullOrEmpty(control.ShowParam);
                if (isnull)
                {
                    control.ImportButton.Visibility = Visibility.Visible;
                    control.SettingButton.Visibility = Visibility.Visible;
                    control.LogoutButton.Visibility = Visibility.Visible;
                    control.ShutdownButton.Visibility = Visibility.Visible;

                }
                else
                {


                    var show = control.ShowParam.Split(',');
                    foreach (var item in show)
                    {
                        switch (item)
                        {
                            case "import":
                                control.ImportButton.Visibility = Visibility.Visible;
                                break;
                            case "setting":
                                control.SettingButton.Visibility = Visibility.Visible;
                                break;
                            case "logout":
                                control.LogoutButton.Visibility = Visibility.Visible;
                                break;
                            case "shutdown":
                                control.ShutdownButton.Visibility = Visibility.Visible;
                                break;

                        }
                    }
                }
            }
        }

        public string ShowParam
        {
            get { return GetValue(ShowParamProperty).ToString(); }
            set { SetValue(ShowParamProperty, value); }
        }

        private void ImportButton_OnClick(object sender, RoutedEventArgs e)
        {
            var onOnFinished = this.OnFinished;
            onOnFinished?.Invoke(this, new SideBarOnFinishedArg(null, SideBarButtonType.Import));
        }

        private void SettingButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.OnFinished?.Invoke(this, new SideBarOnFinishedArg(null, SideBarButtonType.Setting));
        }

        private void LogoutButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.OnFinished?.Invoke(this, new SideBarOnFinishedArg(null, SideBarButtonType.Logout));
            //todo:调用登出接口
            Messenger.Default.Send(new NavigationArg(typeof(LoginPage)), TokenUtil.NavigationToken);

        }

        private void ShutdownButton_OnClick(object sender, RoutedEventArgs e)
        {

            this.OnFinished?.Invoke(this, new SideBarOnFinishedArg(null, SideBarButtonType.Shutdown));
            Messenger.Default.Send("close", TokenUtil.WindowToken);

        }
    }

}
