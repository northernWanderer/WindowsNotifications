﻿using Microsoft.Toolkit.Uwp.Notifications;
using Prism.Mvvm;
using Prism.Regions;

namespace WindowsNotifications.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion("ContentRegion","NotificationView");
            
        }
    }
}
