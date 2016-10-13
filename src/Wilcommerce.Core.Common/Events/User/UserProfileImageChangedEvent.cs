﻿using System;
using Wilcommerce.Core.Infrastructure;

namespace Wilcommerce.Core.Common.Events.User
{
    public class UserProfileImageChangedEvent : DomainEvent
    {
        public Guid UserId { get; }

        public UserProfileImageChangedEvent(Guid userId)
            : base()
        {
            UserId = userId;
        }

        public override string ToString()
        {
            return $"{FiredOn} - User {UserId} changed profile image";
        }
    }
}