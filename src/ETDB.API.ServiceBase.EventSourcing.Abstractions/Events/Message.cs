﻿using System;
using MediatR;

namespace ETDB.API.ServiceBase.EventSourcing.Abstractions.Events
{
    public abstract class Message : INotification
    {
        public string MessageType { get; protected set; }
        public Type Type { get; protected set; }
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
            Type = GetType();
        }
    }
}
