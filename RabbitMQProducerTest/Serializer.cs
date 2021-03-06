﻿using System;
using Newtonsoft.Json;

namespace RabbitMQProducerTest
{
    public class Serializer
    {
        public static string Serialize(object entity)
        {
            try
            {
                return JsonConvert.SerializeObject(entity, Formatting.Indented);
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }
    }
}