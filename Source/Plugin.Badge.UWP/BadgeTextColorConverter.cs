﻿using Plugin.Badge.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;

namespace Plugin.Badge.UWP
{
    public class BadgeTextColorConverter : Windows.UI.Xaml.Data.IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var element = value as Element;
            if (element != null)
            {
                var color = TabBadge.GetBadgeTextColor(element);
                if (color == Color.Default)
                {
                    color = Color.Black;
                }

                return color.ToBrush();
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
