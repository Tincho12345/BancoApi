using Application.Interfaces;
using System;

namespace Shared.Services
{
    public class DateTimeServices : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
