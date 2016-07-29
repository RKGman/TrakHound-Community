﻿using System;
using System.Configuration;
using System.Windows.Media.Imaging;

using TrakHound.API;

namespace TrakHound_Dashboard.Controls.Message_Center
{
    //public enum MessageType
    //{
    //    NOTIFICATION,
    //    DEVICE_ALERT,
    //    WARNING,
    //    ERROR
    //}

    [SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class MessageData
    {
        public MessageData() { }

        public MessageData(Messages.MessageInfo messageInfo)
        {
            if (messageInfo != null)
            {
                Id = messageInfo.Id;
                Type = messageInfo.Type;
                Title = messageInfo.Subject;
                Text = messageInfo.Message;
                if (messageInfo.SentTimestamp.HasValue) AddedTime = messageInfo.SentTimestamp.Value;
                if (messageInfo.ReadTimestamp.HasValue) Read = true;

                Remote = true;
            }
        }

        public string Id { get; set; }

        public Messages.MessageType Type { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string AdditionalInfo { get; set; }

        public BitmapImage Image { get; set; }

        public Action<object> Action { get; set; }

        public object ActionParameter { get; set; }

        public bool Read { get; set; }

        public DateTime AddedTime { get; set; }

        public bool Remote { get; set; }
    }
}
