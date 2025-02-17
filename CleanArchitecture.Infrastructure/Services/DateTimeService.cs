﻿using CleanArchitecture.Application.Interfaces;

namespace CleanArchitecture.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}