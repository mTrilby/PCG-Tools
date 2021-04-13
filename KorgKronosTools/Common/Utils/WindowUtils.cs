// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using Common.Utils;
using Cursor = System.Windows.Input.Cursor;
using MessageBox = System.Windows.MessageBox;

namespace PcgTools.Common.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class WindowUtils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="window"></param>
        /// <param name="text"></param>
        /// <param name="title"></param>
        /// <param name="messageBoxButton"></param>
        /// <param name="messageBoxImage"></param>
        /// <param name="messageBoxResult"></param>
        /// <returns></returns>
        public static global::Common.Windows.Utils.EMessageBoxResult ShowMessageBox(Window window, string text, [NotNull] string title,
            global::Common.Windows.Utils.EMessageBoxButton messageBoxButton,
            global::Common.Windows.Utils.EMessageBoxImage messageBoxImage, global::Common.Windows.Utils.EMessageBoxResult messageBoxResult)
        {
            Debug.Assert(!string.IsNullOrEmpty(text));
            Debug.Assert(!string.IsNullOrEmpty(title));
            
            MessageBoxButton button;
            switch (messageBoxButton)
            {
                case global::Common.Windows.Utils.EMessageBoxButton.Ok:
                    button = MessageBoxButton.OK;
                    break;

                case global::Common.Windows.Utils.EMessageBoxButton.YesNo:
                    button = MessageBoxButton.YesNo;
                    break;
                
                case global::Common.Windows.Utils.EMessageBoxButton.YesNoCancel:
                    button = MessageBoxButton.YesNoCancel;
                    break;

                default:
                    throw new ApplicationException("Illegal message box button");
            }

            MessageBoxImage image;
            switch (messageBoxImage)
            {
            case global::Common.Windows.Utils.EMessageBoxImage.Error:
                image = MessageBoxImage.Error;
                break;

            case global::Common.Windows.Utils.EMessageBoxImage.Warning:
                image = MessageBoxImage.Warning;
                break;

            case global::Common.Windows.Utils.EMessageBoxImage.Exclamation:
                image = MessageBoxImage.Exclamation;
                break;

            case global::Common.Windows.Utils.EMessageBoxImage.Information:
                image = MessageBoxImage.Information;
                break;

            default:
                throw new ApplicationException("Illegal message box image");
            }

            MessageBoxResult result;
            switch (messageBoxResult)
            {
            case global::Common.Windows.Utils.EMessageBoxResult.Ok:
                result = MessageBoxResult.OK;
                break;

            case global::Common.Windows.Utils.EMessageBoxResult.Yes:
                result = MessageBoxResult.Yes;
                break;

            case global::Common.Windows.Utils.EMessageBoxResult.No:
                result = MessageBoxResult.No;
                break;

            case global::Common.Windows.Utils.EMessageBoxResult.None:
                result = MessageBoxResult.None;
                break;

            case global::Common.Windows.Utils.EMessageBoxResult.Cancel:
                result = MessageBoxResult.Cancel;
                break;

            default:
                throw new ApplicationException("Illegal message box result");
            }

            MessageBoxResult dialogResult = window == null ? MessageBox.Show(text, title, button, image, result) : 
                                                MessageBox.Show(window, text, title, button, image, result);

            global::Common.Windows.Utils.EMessageBoxResult returnResult;
            switch (dialogResult)
            {
            case MessageBoxResult.OK:
                returnResult = global::Common.Windows.Utils.EMessageBoxResult.Ok;
                break;

            case MessageBoxResult.Yes:
                returnResult = global::Common.Windows.Utils.EMessageBoxResult.Yes;
                break;

            case MessageBoxResult.No:
                returnResult = global::Common.Windows.Utils.EMessageBoxResult.No;
                break;

            case MessageBoxResult.Cancel:
                returnResult = global::Common.Windows.Utils.EMessageBoxResult.Cancel;
                break;

            case MessageBoxResult.None:
                returnResult = global::Common.Windows.Utils.EMessageBoxResult.None;
                break;

            default:
                throw new ApplicationException("Illegal message box result");
            }

            return returnResult;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="eCursor"></param>
        public static void SetCursor(global::Common.Windows.Utils.ECursor eCursor)
        {
            Cursor cursor;
            switch (eCursor)
            {
                case global::Common.Windows.Utils.ECursor.Wait:
                cursor = Cursors.Wait;
                    break;

                case global::Common.Windows.Utils.ECursor.Arrow:
                    cursor = Cursors.Arrow;
                    break;

                default:
                    throw new ApplicationException("Illegal cursor");
            }

            Mouse.OverrideCursor = cursor;
        }
    }
}