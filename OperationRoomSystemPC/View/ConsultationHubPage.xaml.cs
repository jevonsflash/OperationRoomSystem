using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OperationRoomSystemPC.View
{
    /// <summary>
    /// ConsultationHubPage.xaml 的交互逻辑
    /// </summary>
    public partial class ConsultationHubPage : Page
    {
        public ConsultationHubPage()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var tb = sender as ToggleButton;
            if (!(bool)tb.IsChecked)
            {
                tb.IsChecked = true;
            }
        }

        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            var tb = sender as ToggleButton;
            if (!(bool)tb.IsChecked)
            {
                tb.IsChecked = true;
            }
        }
    }
}
