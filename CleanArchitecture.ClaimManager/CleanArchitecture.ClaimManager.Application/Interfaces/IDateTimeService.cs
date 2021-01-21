using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
