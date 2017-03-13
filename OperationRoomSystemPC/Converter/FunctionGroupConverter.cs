using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using OperationRoomSystemPC.Enum;

namespace OperationRoomSystemPC.Converter
{
    public class FunctionGroupConverter : IValueConverter
    {
        public int PivotPoint { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var controlFuncStr = parameter as string;
            var currentFunc = value is FunctionGroupEnum ? (FunctionGroupEnum)value : FunctionGroupEnum.Function1;
            var currentFuncStr = currentFunc.ToString();
            return controlFuncStr == currentFuncStr;

        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            FunctionGroupEnum result = FunctionGroupEnum.Function1;
            if ((bool)value)
            {
                FunctionGroupEnum.TryParse((parameter as string), out result);
            }
            return result;

        }
    }
}
