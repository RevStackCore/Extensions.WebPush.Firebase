using System;
namespace RevStackCore.Extensions.WebPush.Firebase
{
    public interface INotificationPayload
    {
        string Body { get; set; }
        string Title { get; set; }
        string Icon { get; set; }
        string ClickAction { get; set; }
        string Sound { get; set; }

    }
}
