using System;
using System.Windows;
using System.Windows.Controls;

namespace OperationRoomSystemPC.Control
{
    /// <summary>
    /// Interaction logic for BindableRichTextbox.xaml
    /// </summary>
    public partial class RichTextEditor : UserControl
    {
        public static readonly DependencyProperty TextProperty =
          DependencyProperty.Register("Text", typeof(string), typeof(RichTextEditor),
          new PropertyMetadata(string.Empty));

        public RichTextEditor()
        {
            InitializeComponent();
        }

        public string Text
        {
            get { return GetValue(TextProperty) as string; }
            set
            {
                SetValue(TextProperty, value);
            }
        }


        public static readonly DependencyProperty IsToolVisibleProperty =
         DependencyProperty.Register("IsToolVisible", typeof(bool), typeof(RichTextEditor),
         new PropertyMetadata(true, IsToolVisiblePropertyChanged));

        private static void IsToolVisiblePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        public bool IsToolVisible
        {
            get { return (bool)GetValue(IsToolVisibleProperty); }
            set
            {
                SetValue(IsToolVisibleProperty, value);
            }
        }

        private void MainRTB_OnGotFocus(object sender, RoutedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void MainRTB_OnLostFocus(object sender, RoutedEventArgs e)
        {
           // throw new NotImplementedException();
        }
    }
}
