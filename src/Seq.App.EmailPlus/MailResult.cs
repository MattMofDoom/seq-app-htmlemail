﻿using System;

namespace Seq.App.EmailPlus
{
    public class MailResult
    {
        public bool Success { get; set; }
        public DeliveryType Type { get; set; }
        public string LastServer { get; set; }
        public Exception Errors { get; set; }
    }
}