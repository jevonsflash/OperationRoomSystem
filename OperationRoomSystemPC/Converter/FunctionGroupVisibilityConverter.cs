using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using OperationRoomSystemPC.Enum;

namespace OperationRoomSystemPC.Converter
{
    public class FunctionGroupVisibilityConverter : IValueConverter
    {

        public int PivotPoint { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var controlFuncStr = parameter as string;
            var currentFunc = value is FunctionGroupEnum ? (FunctionGroupEnum)value : FunctionGroupEnum.Function1;
            var currentFuncStr = currentFunc.ToString();
            var result = controlFuncStr == currentFuncStr;
            return result ? Visibility.Visible : Visibility.Collapsed;


        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;

        }


    }
}
