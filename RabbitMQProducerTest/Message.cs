﻿using System;

namespace RabbitMQProducerTest
{
    public class Message
    {
        public short Type { get; set; }
        public string Payload { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}