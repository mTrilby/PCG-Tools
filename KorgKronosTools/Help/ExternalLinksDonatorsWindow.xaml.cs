#region copyright

// (c) Copyright 2011-2023 MiKeSoft, Michel Keijzers, All rights reserved

#endregion

#region using

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using Common.PcgToolsResources;

#endregion

// (c) 2011 Michel Keijzers

namespace PcgTools.Help
{
    /// <summary>
    /// </summary>
    public partial class ExternalLinksDonatorsWindow // : Window
    {
        /// <summary>
        /// </summary>
        public ExternalLinksDonatorsWindow()
        {
            InitializeComponent();

            var externalItems = new List<ExternalItem>
            {
                new()
                {
                    Name = "Smyth Rocks", Description = "Donator"
                },
                new()
                {
                    Name = "needamuse", Description = "Donator"
                },
                new()
                {
                    Name = "Kevin Nolan", Description = "Donator"
                },
                new()
                {
                    Name = "Mike Hildner", Description = "Donator"
                },
                new()
                {
                    Name = "Bruno Santos", Description = "Donator"
                },
                new()
                {
                    Name = "Joe Keller", Description = "Donator",
                    Url = "http://www.keller12.de", BitmapPath = "keller12.jpg"
                },
                new()
                {
                    Name = "Synthesaurus",
                    Description = "Donator",
                    Url = "https://www.patreon.com/synthesaurus",
                    BitmapPath = "Synthesaurus.png"
                },
                new()
                {
                    Name = "Philip Joseph", Description = "Donator"
                },
                new()
                {
                    Name = "Igor Elshaidt", Description = "Donator"
                },
                new()
                {
                    Name = "Daan Andriessen", Description = "Donator",
                    Url = "http://www.studiodebovenkamer.nl", BitmapPath = "BK-facebook.gif"
                },
                new()
                {
                    Name = "Mathieu Maes", Description = "Donator",
                    Url = "http://partycoverband.wix.com/cupsandplates", BitmapPath = "Cupsandplates.png"
                },
                new()
                {
                    Name = "Jim Knopf", Description = "Donator"
                },
                new()
                {
                    Name = "Olaf Arweiler", Description = "Donator"
                },
                new()
                {
                    Name = "Martin Hines", Description = "Donator"
                },
                new()
                {
                    Name = "Batisse", Description = "Donator"
                },
                new()
                {
                    Name = "Traugott", Description = "Donator"
                },
                new()
                {
                    Name = "Wan Kemper", Description = "Donator"
                },
                new()
                {
                    Name = "robbie50", Description = "Donator"
                },
                new()
                {
                    Name = "Steffen Traeger", Description = "Donator"
                },
                new()
                {
                    Name = "Greg Heslington", Description = "Donator"
                },
                new()
                {
                    Name = "Artur Dellarte", Description = "Donator"
                },
                new()
                {
                    Name = "Michael Maschek", Description = "Donator",
                    Url = "https://www.facebook.com/celticvoyagerband", BitmapPath = "celticvoyager.png"
                },
                new()
                {
                    Name = "Dave Gibson", Description = "Donator"
                },
                new()
                {
                    Name = "Dreamland", Description = "Donator",
                    Url = "http://www.dreamland-recording.de", BitmapPath = "dreamland.jpg"
                },
                new()
                {
                    Name = "Norman Clasper", Description = "Donator"
                },
                new()
                {
                    Name = "Tim Godfrey", Description = "Donator"
                },
                new()
                {
                    Name = "Yuma", Description = "Donator"
                },
                new()
                {
                    Name = "Ralph Hopstaken", Description = "Donator"
                },
                new()
                {
                    Name = "Enrico Puglisi", Description = "Donator",
                    Url = "https://www.facebook.com/kronospatchlab", BitmapPath = "KronosPatchLab.png"
                },
                new()
                {
                    Name = "phattbuzz", Description = "Donator"
                },
                new()
                {
                    Name = "Jerry", Description = "Donator"
                },
                new()
                {
                    Name = "Wilton Vought", Description = "Donator"
                },
                new()
                {
                    Name = "Fred Alberni/Farrokh Kouhang", Description = "Donator"
                },
                new()
                {
                    Name = "Toon Martens (Project)", Description = "Donator",
                    Url = "http://www.toonmartensproject.net/", BitmapPath = "tmp.jpg"
                },
                new()
                {
                    Name = "Jim G", Description = "Donator"
                },
                new()
                {
                    Name = "Adrian", Description = "Donator"
                },
                new()
                {
                    Name = "Tim Möller", Description = "Donator"
                },
                //new ExternalItem
                //{
                //    Does not want to be on the list
                //    Name= "Christian Moss", Description = "Donator",
                //},
                new()
                {
                    Name = "Sidney Leal", Description = "Donator"
                },
                new()
                {
                    Name = "Steve Baker", Description = "Donator"
                }
            };

            var linkButtons = new List<UserControlExternalLink>
            {
                ButtonLink1,
                ButtonLink2,
                ButtonLink3,
                ButtonLink4,
                ButtonLink5,
                ButtonLink6,
                ButtonLink7,
                ButtonLink8,
                ButtonLink9,
                ButtonLink10,
                ButtonLink11,
                ButtonLink12,
                ButtonLink13,
                ButtonLink14,
                ButtonLink15,
                ButtonLink16,
                ButtonLink17,
                ButtonLink18,
                ButtonLink19,
                ButtonLink20,
                ButtonLink21,
                ButtonLink22,
                ButtonLink23,
                ButtonLink24,
                ButtonLink25,
                ButtonLink26,
                ButtonLink27,
                ButtonLink28,
                ButtonLink29,
                ButtonLink30,
                ButtonLink31,
                ButtonLink32,
                ButtonLink33,
                ButtonLink34,
                ButtonLink35,
                ButtonLink36,
                ButtonLink37,
                ButtonLink38,
                ButtonLink39,
                ButtonLink40,
                ButtonLink41,
                ButtonLink42,
                ButtonLink43,
                ButtonLink44,
                ButtonLink45,
                ButtonLink46,
                ButtonLink47,
                ButtonLink48,
                ButtonLink49,
                ButtonLink50
            };

            for (var index = 0; index < externalItems.Count; index++)
            {
                var userControl = linkButtons[index];
                userControl.PreviewMouseLeftButtonUp += ButtonLinkOnPreviewMouseLeftButtonUp;
                userControl.Tag = externalItems[index];
                userControl.DataContext = externalItems[index];
            }

            for (var index = externalItems.Count; index < linkButtons.Count; index++)
            {
                linkButtons[index].Visibility = Visibility.Collapsed;
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="mouseButtonEventArgs"></param>
        private void ButtonLinkOnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs mouseButtonEventArgs)
        {
            var userControlExternalLink = sender as UserControlExternalLink;
            if (userControlExternalLink != null)
            {
                var item = userControlExternalLink.Tag as ExternalItem;
                if (item != null && item.Url != null)
                {
                    ShowUrl(item.Url);
                }
            }
        }

        /// <summary>
        /// </summary>
        private void ShowUrl(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo(url));
            }
            catch (Exception exception)
            {
                MessageBox.Show(this, $"{Strings.LinkWarning}.\n{Strings.Message}:{exception.Message}",
                    Strings.PcgTools,
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}