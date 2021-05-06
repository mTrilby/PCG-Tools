using System;
using Avalonia.Data.Converters;

namespace PCGTools_Avalonia.Converters
{
    /// <summary>
    /// 
    /// </summary>
    public class EnumToBooleanConverter : IValueConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            // You could also directly pass an enum value using {x:Static}, 
            // then there is no need to parse 
            var parameterString = parameter as string;
            if (parameterString == null)
                return false;

            if (Enum.IsDefined(value.GetType(), value) == false)
                return false;

            object parameterValue = Enum.Parse(value.GetType(), parameterString);

            return parameterValue.Equals(value);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var parameterString = parameter as string;
            if (parameterString == null)
                return false;

            return Enum.Parse(targetType, parameterString);
        }
    } 
}
