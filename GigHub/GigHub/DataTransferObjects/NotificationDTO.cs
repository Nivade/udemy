﻿using GigHub.Models;
using System;

namespace GigHub.DataTransferObjects
{
    public class NotificationDTO
    {
        public DateTime DateTime { get; set; }
        public NotificationType Type { get; set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalVenue { get; set; }
        public GigDTO Gig { get; set; }

    }
}