﻿using CometLibraryNS.Enums;
using Playnite.SDK;
using System;
using System.Globalization;
using System.Windows.Data;

namespace CometLibraryNS.Converters
{
    public class DownloadStatusEnumToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case DownloadStatus.Queued:
                    value = ResourceProvider.GetString(LOC.CometDownloadQueued);
                    break;
                case DownloadStatus.Running:
                    value = ResourceProvider.GetString(LOC.CometDownloadRunning);
                    break;
                case DownloadStatus.Canceled:
                    value = ResourceProvider.GetString(LOC.CometDownloadCanceled);
                    break;
                case DownloadStatus.Paused:
                    value = ResourceProvider.GetString(LOC.CometDownloadPaused);
                    break;
                case DownloadStatus.Completed:
                    value = ResourceProvider.GetString(LOC.CometDownloadCompleted);
                    break;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
