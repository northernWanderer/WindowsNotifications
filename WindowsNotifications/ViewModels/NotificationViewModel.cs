using Microsoft.Toolkit.Uwp.Notifications;
using Prism.Commands;
using System;
using System.Windows.Input;

namespace WindowsNotifications.ViewModels
{
    internal class NotificationViewModel
    {
        public ICommand ShowNotificationCommand { get; set; }
        private ToastContentBuilder _toastContentBuilder;

        public NotificationViewModel()
        {
            _toastContentBuilder = new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Такое же уведомление будет в СМФУ ПА")
                .AddText("Только тут будет больше полезной информации.")
                .AddInlineImage(new Uri("C:\\Users\\Samusik-KA\\source\\repos\\WindowsNotifications\\WindowsNotifications\\6cdb07fa913811ee885bca123cab517e_upscaled.jpg"))
                .AddAppLogoOverride(new Uri("C:\\Users\\Samusik-KA\\source\\repos\\WindowsNotifications\\WindowsNotifications\\icon.ico"), ToastGenericAppLogoCrop.Circle)
                .AddButton(new ToastButton()
                    .SetContent("Like")
                    .AddArgument("action", "like")
                    .SetBackgroundActivation());

            ShowNotificationCommand = new DelegateCommand(ShowNotification);
        }

        private void ShowNotification()
        {
            _toastContentBuilder.Show();
            // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 6 (or later), then your TFM must be net6.0-windows10.0.17763.0 or greater
        }
    }
}
