using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Data;
using System.Globalization;

namespace DoodleLand.UserControls
{

    //TODO CODE REVIEW 

    //name this TimeScalePostion converter and place in separate file, one class per file.

    public class KeyframeListBoxConverter : DependencyObject, IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Length > 0)
            {
                double result = 0;
                try
                {
                    double width = (double)value[0];
                    double max = (double)value[1];
                    double time = (double)value[2];
                    double scale = (double)value[3];
                    if (time % 2 != 0) width -= 1;
                    double div = width / max;

                    return result = (div * time * scale);
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }


    //TODO CODE REVIEW ( name this to CustomListBox  that means what it is, 
    //do we even need a CustomListBox?   what are we doing logically thats different from listbox?




    public class KeyframeListBox : ListBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new KeyframeListBoxItem();
        }
    }


    //TODO seems like a regular list box with multiseect would be fine..
    //there si s 
    //listbox_PreviewMouseDown

    public class KeyframeListBoxItem : ListBoxItem
    {
        private bool _mouseDownAndSelected = false;

        protected override void OnPreviewMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e)
        {
            if (!IsSelected)
            {
                base.OnPreviewMouseLeftButtonDown(e);

                return;
            }

            e.Handled = true;
            _mouseDownAndSelected = true;
        }

        protected override void OnPreviewMouseLeftButtonUp(System.Windows.Input.MouseButtonEventArgs e)
        {
            if (_mouseDownAndSelected && IsSelected)
            {
                IsSelected = _mouseDownAndSelected = false;
            }

            base.OnPreviewMouseLeftButtonUp(e);
        }
    }
}
