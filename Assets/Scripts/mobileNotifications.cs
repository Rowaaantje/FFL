using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class mobileNotifications : MonoBehaviour
{
// Start is called before the first frame update
    void Start()
    {
            //Remove notifications that have already been displayed
            AndroidNotificationCenter.CancelAllDisplayedNotifications();

            //Create the Android Notification Channel to send messages through
            var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Notifications Channel",
            Importance = Importance.Default,
            Description = "Reminder notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

            //Create the Notification that is going to be sent
            var notification = new AndroidNotification();
            notification.Title = "Gezond?";
            notification.Text = "Vergeet niet jou dagelijkse oefeningen te doen!";

            notification.FireTime = System.DateTime.Now.AddMinutes(5);

            //Send the Notification
            var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");

            //If the script is run and a message is already scheduled, cancel it and re-schedule another message
            if (AndroidNotificationCenter.CheckScheduledNotificationStatus (id) == NotificationStatus.Scheduled)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification (notification, "channel_id");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
