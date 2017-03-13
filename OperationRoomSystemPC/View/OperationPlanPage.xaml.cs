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
using OperationRoomSystemPC.Control;
using OperationRoomSystemPC.Util;

namespace OperationRoomSystemPC.View
{
    /// <summary>
    /// OperationPlanPage.xaml 的交互逻辑
    /// </summary>
    public partial class OperationPlanPage : Page
    {
        private bool _isEdit;

        public OperationPlanPage()
        {

            InitializeComponent();
            this.Loaded += OperationPlanPage_Loaded;
        }

        private void OperationPlanPage_Loaded(object sender, RoutedEventArgs e)
        {
            this._isEdit = false;
            SetStatus();

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _isEdit = !_isEdit;

            SetStatus();

        }

        private void SetStatus()
        {
            if (_isEdit)
            {
                this.SaveButton.Visibility = Visibility.Visible;
                this.EditButton.Visibility = Visibility.Collapsed;
                ElementTreeHelper.FindVisualChildren<RichTextEditor>(this.OperationPlanItemsControl)
                    .ForEach(c => c.IsToolVisible = true);
            }
            else
            {
                this.SaveButton.Visibility = Visibility.Collapsed;
                this.EditButton.Visibility = Visibility.Visible;
                ElementTreeHelper.FindVisualChildren<RichTextEditor>(this.OperationPlanItemsControl)
                    .ForEach(c => c.IsToolVisible = false);
            }
        }
    }
}
