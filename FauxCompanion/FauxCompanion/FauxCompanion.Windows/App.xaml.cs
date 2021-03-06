﻿using System;

using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace EnergonSoftware.FauxCompanion.Windows
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();

            Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
#if DEBUG
            if(System.Diagnostics.Debugger.IsAttached) {
                DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            InitWindow(e);
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            SuspendingDeferral deferral = e.SuspendingOperation.GetDeferral();

            //TODO: Save application state and stop any background activity

            deferral.Complete();
        }

        private void InitWindow(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame ?? NewContentFrame(e);
            Window.Current.Content = rootFrame;

            if(e.PrelaunchActivated) {
                return;
            }

            if(null == rootFrame.Content) {
                rootFrame.Navigate(typeof(MainPage), e.Arguments);
            }

            Window.Current.Activate();
        }

        private Frame NewContentFrame(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = new Frame();
            rootFrame.NavigationFailed += OnNavigationFailed;

            if(e.PreviousExecutionState == ApplicationExecutionState.Terminated) {
                //TODO: Load state from previously suspended application
            }

            return rootFrame;
        }
    }
}
