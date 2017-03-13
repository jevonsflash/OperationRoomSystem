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
    /// TopBarControl.xaml 的交互逻辑
    /// </summary>
    public partial class TopBarControl : UserControl
    {
        public event EventHandler<TopBarOnFinishedArg> OnFinished;

        public TopBarControl()
        {

            InitializeComponent();
            this.PopupRegionGrid.Visibility = Visibility.Collapsed;
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.OnFinished?.Invoke(this, new TopBarOnFinishedArg(null, TopBarButtonType.Back));
        }

        private void HomeButton_OnClick(object sender, RoutedEventArgs e)
        {
            var onOnFinished = this.OnFinished;
            onOnFinished?.Invoke(this, new TopBarOnFinishedArg(null, TopBarButtonType.Home));
            Messenger.Default.Send(new NavigationArg(typeof(IndexPage)), TokenUtil.NavigationToken);

        }

        private void RefreshButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.OnFinished?.Invoke(this, new TopBarOnFinishedArg(null, TopBarButtonType.Refresh));
        }

        private void MinimizeButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.OnFinished?.Invoke(this, new TopBarOnFinishedArg(null, TopBarButtonType.Minimize));
            Messenger.Default.Send("minimize", TokenUtil.WindowToken);
        }

        private void PopupRegionGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.PopupRegionGrid.Visibility = Visibility.Collapsed;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.PopupRegionGrid.Visibility = Visibility.Visible;
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            this.PopupRegionGrid.Visibility = Visibility.Collapsed;
        }

        private void ShortcutButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.OnFinished?.Invoke(this, new TopBarOnFinishedArg(null, TopBarButtonType.Shortcut));
        }
    }
}
