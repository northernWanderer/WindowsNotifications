﻿using Prism.Ioc;
using System.Windows;
using WindowsNotifications.Views;

namespace WindowsNotifications
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NotificationView>("NotificationView");
        }
    }
}
