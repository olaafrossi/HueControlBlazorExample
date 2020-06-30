﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using HueControlBlazorExampleWebApp.Models;

namespace HueControlBlazorExampleWebApp.Services
{
    public interface IMessagesPublisher
    {
        Task PublishAsync(Message message);
    }

    public class MessagesPublisher : IMessagesPublisher
    {
        private readonly ChannelWriter<Message> _writer;

        public MessagesPublisher(ChannelWriter<Message> writer)
        {
            _writer = writer;
        }

        public async Task PublishAsync(Message message)
        {
            await _writer.WriteAsync(message);
        }
    }
}
