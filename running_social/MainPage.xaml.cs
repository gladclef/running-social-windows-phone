﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace running_social
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void AppBarButton_Click_Settings(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SettingsPage));
        }

        private void AppBarButton_Click_Change_Account(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SignupPage));
        }

        private void HomeButton_Click_Plan_Run(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PlanRunPage));
        }

        private void HomeButton_Click_Run_Now(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CurrentRunPage));
        }

        private void HomeButton_Click_My_Recent_Runs(object sender, RoutedEventArgs e)
        {
            // TODO: open personal profile page
            Frame.Navigate(typeof(UserProfile));
        }

        private void HomeButton_Click_Friends_List(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FriendsPage));
        }
    }
}
