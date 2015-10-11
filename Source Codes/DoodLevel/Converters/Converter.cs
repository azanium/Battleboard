using System;
using System.Collections.Generic;
using System.Windows.Data;
using System.Globalization;

using DoodleLand.Controllers;

namespace DoodleLand.Converters
{
    public class DoubleToStringConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double)
            {
                double number = (double)value;
                return number.ToString("F2");
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        #endregion
    }

    public class KeyframeDilateConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            /*
            if (SpiritAnimatorController.Instance.ActiveSpirit.ActiveBehavior != null)
            {
                double dilate = SpiritAnimatorController.Instance.ActiveSpirit.ActiveBehavior.TimeDilateFactor;
                if (value is double)
                {
                    double num = ((double)value * dilate);
                    return num.ToString("F2");
                }
            }*/
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        #endregion
    }

}
