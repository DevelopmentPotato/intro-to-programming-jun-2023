using BusinessCLockApi.Models;

namespace BusinessCLockApi.Services;

public class BusinessClockService
{
    public ISystemTime _systemTime;
    public BusinessClockService(ISystemTime systemTime)
    {
        _systemTime = systemTime;
    }

    public GetStatusResponse GetCurrentStatus()
    {
        DateTime now = _systemTime.GetCurrent();
        bool isOpen = now.DayOfWeek != DayOfWeek.Sunday && now.DayOfWeek != DayOfWeek.Saturday;
        return new GetStatusResponse { Open = isOpen };
    }
}

public interface ISystemTime
{
    DateTime GetCurrent();
}

public class SystemTime
{
    public DateTime GetCurrent() { 
        return DateTime.Now;
    }
}