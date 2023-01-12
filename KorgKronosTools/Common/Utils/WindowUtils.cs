#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using Common.Utils;

#endregion

namespace PcgTools.Common.Utils
{
    /// <summary>
    /// </summary>
    public abstract class WindowUtils
    {
        /// <summary>
        /// </summary>
        /// <param name="window"></param>
        /// <param name="text"></param>
        /// <param name="title"></param>
        /// <param name="messageBoxButton"></param>
        /// <param name="messageBoxImage"></param>
        /// <param name="messageBoxResult"></param>
        /// <returns></returns>
        public static WindowUtil.EMessageBoxResult ShowMessageBox(Window window, string text, [NotNull] string title,
            WindowUtil.EMessageBoxButton messageBoxButton,
            WindowUtil.EMessageBoxImage messageBoxImage, WindowUtil.EMessageBoxResult messageBoxResult)
        {
            Debug.Assert(!string.IsNullOrEmpty(text));
            Debug.Assert(!string.IsNullOrEmpty(title));

            MessageBoxButton button;
            switch (messageBoxButton)
            {
                case WindowUtil.EMessageBoxButton.Ok:
                    button = MessageBoxButton.OK;
                    break;

                case WindowUtil.EMessageBoxButton.YesNo:
                    button = MessageBoxButton.YesNo;
                    break;

                case WindowUtil.EMessageBoxButton.YesNoCancel:
                    button = MessageBoxButton.YesNoCancel;
                    break;

                default:
                    throw new ApplicationException("Illegal message box button");
            }

            MessageBoxImage image;
            switch (messageBoxImage)
            {
                case WindowUtil.EMessageBoxImage.Error:
                    image = MessageBoxImage.Error;
                    break;

                case WindowUtil.EMessageBoxImage.Warning:
                    image = MessageBoxImage.Warning;
                    break;

                case WindowUtil.EMessageBoxImage.Exclamation:
                    image = MessageBoxImage.Exclamation;
                    break;

                case WindowUtil.EMessageBoxImage.Information:
                    image = MessageBoxImage.Information;
                    break;

                default:
                    throw new ApplicationException("Illegal message box image");
            }

            MessageBoxResult result;
            switch (messageBoxResult)
            {
                case WindowUtil.EMessageBoxResult.Ok:
                    result = MessageBoxResult.OK;
                    break;

                case WindowUtil.EMessageBoxResult.Yes:
                    result = MessageBoxResult.Yes;
                    break;

                case WindowUtil.EMessageBoxResult.No:
                    result = MessageBoxResult.No;
                    break;

                case WindowUtil.EMessageBoxResult.None:
                    result = MessageBoxResult.None;
                    break;

                case WindowUtil.EMessageBoxResult.Cancel:
                    result = MessageBoxResult.Cancel;
                    break;

                default:
                    throw new ApplicationException("Illegal message box result");
            }

            var dialogResult = window == null
                ? MessageBox.Show(text, title, button, image, result)
                : MessageBox.Show(window, text, title, button, image, result);

            WindowUtil.EMessageBoxResult returnResult;
            switch (dialogResult)
            {
                case MessageBoxResult.OK:
                    returnResult = WindowUtil.EMessageBoxResult.Ok;
                    break;

                case MessageBoxResult.Yes:
                    returnResult = WindowUtil.EMessageBoxResult.Yes;
                    break;

                case MessageBoxResult.No:
                    returnResult = WindowUtil.EMessageBoxResult.No;
                    break;

                case MessageBoxResult.Cancel:
                    returnResult = WindowUtil.EMessageBoxResult.Cancel;
                    break;

                case MessageBoxResult.None:
                    returnResult = WindowUtil.EMessageBoxResult.None;
                    break;

                default:
                    throw new ApplicationException("Illegal message box result");
            }

            return returnResult;
        }

        /// <summary>
        /// </summary>
        /// <param name="eCursor"></param>
        public static void SetCursor(WindowUtil.ECursor eCursor)
        {
            Cursor cursor;
            switch (eCursor)
            {
                case WindowUtil.ECursor.Wait:
                    cursor = Cursors.Wait;
                    break;

                case WindowUtil.ECursor.Arrow:
                    cursor = Cursors.Arrow;
                    break;

                default:
                    throw new ApplicationException("Illegal cursor");
            }

            Mouse.OverrideCursor = cursor;
        }
    }
}