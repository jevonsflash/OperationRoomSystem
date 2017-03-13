using System;
using System.Collections;
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
using OperationRoomSystemPC.Common;

namespace OperationRoomSystemPC.Control
{
    /// <summary>
    /// SideSelectorControl.xaml 的交互逻辑
    /// </summary>
    public partial class SideSelectorControl : UserControl
    {
        public SideSelectorControl()
        {
            InitializeComponent();
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            // throw new NotImplementedException();
        }

        public static DependencyProperty HeadTitleProperty =
DependencyProperty.Register("HeadTitle", typeof(string), typeof(SideSelectorControl), new FrameworkPropertyMetadata("Title", HeadTitlePropertyChanged));

        private static void HeadTitlePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as SideSelectorControl;
            control.TitleButton.Content = control.HeadTitle;

        }

        public string HeadTitle
        {
            get { return GetValue(HeadTitleProperty).ToString(); }
            set { SetValue(HeadTitleProperty, value); }
        }


        public static DependencyProperty SelectorItemsSourceProperty =
DependencyProperty.Register("SelectorItemsSource", typeof(IEnumerable), typeof(SideSelectorControl), new FrameworkPropertyMetadata("Title", SelectorItemsSourcePropertyChanged));

        private static void SelectorItemsSourcePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as SideSelectorControl;
            control.BodyList.ItemsSource = control.SelectorItemsSource;

        }

        public IEnumerable SelectorItemsSource
        {
            get { return GetValue(SelectorItemsSourceProperty) as IEnumerable; }
            set { SetValue(SelectorItemsSourceProperty, value); }
        }
    }
}
