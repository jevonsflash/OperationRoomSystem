﻿using System;
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

namespace OperationRoomSystemPC.Control
{
    /// <summary>
    /// SimpleKeyValueControl.xaml 的交互逻辑
    /// </summary>
    public partial class SimpleKeyValueControl : UserControl
    {
        public SimpleKeyValueControl()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //if (this.FontSize != default(double))
            //{
            //    this.KeyLabel.FontSize = FontSize;
            //    this.ValueLabel.FontSize = FontSize;

            //}


        }

        public static DependencyProperty KeyTextProperty =
            DependencyProperty.Register("KeyText", typeof(string), typeof(SimpleKeyValueControl), new FrameworkPropertyMetadata(KeyTextPropertyChanged));

        private static void KeyTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var simpleKeyValueControl = d as SimpleKeyValueControl;
            if (simpleKeyValueControl != null)
                simpleKeyValueControl.KeyLabel.Content = simpleKeyValueControl.KeyText;
        }

        public string KeyText
        {
            get { return GetValue(KeyTextProperty).ToString(); }
            set { SetValue(KeyTextProperty, value); }
        }

        public static DependencyProperty ValueTextProperty =
          DependencyProperty.Register("ValueText", typeof(string), typeof(SimpleKeyValueControl), new FrameworkPropertyMetadata(ValueTextPropertyChanged));

        private static void ValueTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var simpleKeyValueControl = d as SimpleKeyValueControl;
            if (simpleKeyValueControl != null)
                simpleKeyValueControl.ValueLabel.Content = simpleKeyValueControl.ValueText;
        }

        public string ValueText
        {
            get { return GetValue(ValueTextProperty).ToString(); }
            set { SetValue(ValueTextProperty, value); }
        }


        public static DependencyProperty UnitTextProperty =
          DependencyProperty.Register("UnitText", typeof(string), typeof(SimpleKeyValueControl), new FrameworkPropertyMetadata(UnitTextPropertyChanged));

        private static void UnitTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var simpleKeyValueControl = d as SimpleKeyValueControl;
            if (simpleKeyValueControl != null)
                simpleKeyValueControl.UnitLabel.Content = simpleKeyValueControl.UnitText;
        }

        public string UnitText
        {
            get { return GetValue(UnitTextProperty).ToString(); }
            set { SetValue(UnitTextProperty, value); }
        }

        public static DependencyProperty TextSizeProperty =
          DependencyProperty.Register("TextSize", typeof(double), typeof(SimpleKeyValueControl), new FrameworkPropertyMetadata(TextSizePropertyChanged));

        private static void TextSizePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var simpleKeyValueControl = d as SimpleKeyValueControl;
            if (simpleKeyValueControl != null)
            {
                simpleKeyValueControl.ValueLabel.FontSize = (simpleKeyValueControl.TextSize);
                simpleKeyValueControl.KeyLabel.FontSize = (simpleKeyValueControl.TextSize);
                simpleKeyValueControl.SplitLabel.FontSize = simpleKeyValueControl.TextSize;
                simpleKeyValueControl.UnitLabel.FontSize = simpleKeyValueControl.TextSize;
            }
        }

        public double TextSize
        {
            get { return Convert.ToDouble(GetValue(TextSizeProperty)); }
            set { SetValue(TextSizeProperty, value); }
        }


        public static DependencyProperty TextColorProperty =
          DependencyProperty.Register("TextColor", typeof(Brush), typeof(SimpleKeyValueControl), new FrameworkPropertyMetadata(TextColorPropertyChanged));

        private static void TextColorPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var simpleKeyValueControl = d as SimpleKeyValueControl;
            if (simpleKeyValueControl != null)
            {
                simpleKeyValueControl.ValueLabel.Foreground =  (simpleKeyValueControl.TextColor);
                simpleKeyValueControl.KeyLabel.Foreground =  (simpleKeyValueControl.TextColor);
                simpleKeyValueControl.SplitLabel.Foreground =  (simpleKeyValueControl.TextColor);
                simpleKeyValueControl.UnitLabel.Foreground =  (simpleKeyValueControl.TextColor);
            }
        }

        public Brush TextColor
        {
            get { return (Brush)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
    }
}
