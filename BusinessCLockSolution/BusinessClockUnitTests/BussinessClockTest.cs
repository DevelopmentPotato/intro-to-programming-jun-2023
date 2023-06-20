using BusinessCLockApi.Models;
using BusinessCLockApi.Services;
using Moq;

namespace BusinessClockUnitTests;

public class BussinessClockTest
{
    [Fact]
    public void ClosedOnSaturday()
    {
        var stubbedSaturdaySystemTime = new Mock<ISystemTime>();
        stubbedSaturdaySystemTime.Setup(c => c.GetCurrent())
            .Returns(new DateTime(2023, 6, 17, 9, 5, 00));
        //given
        BusinessClockService clock = new BusinessClockService(stubbedSaturdaySystemTime.Object);

        //when
        GetStatusResponse response = clock.GetCurrentStatus();

        //then
        Assert.False(response.Open);
    }

    [Fact] 
    public void ClosedOnSunday()
    {
        var stubbedSundayClock = new Mock<ISystemTime>();
        stubbedSundayClock.Setup(c => c.GetCurrent())
            .Returns(new DateTime(2023, 6, 18, 9, 5, 00));
        //given
        BusinessClockService clock = new BusinessClockService(stubbedSundayClock.Object);
        
        //when
        GetStatusResponse response = clock.GetCurrentStatus();

        //then
        Assert.False(response.Open);
    }

    [Theory]
    [InlineData("6/19/2023 9:00:00 AM")]
    [InlineData("6/19/2023 4:59:00 PM")]
    public void OpenTimes(string dateTime)
    {
        var stubbedClock = new Mock<ISystemTime>();
        stubbedClock.Setup(c => c.GetCurrent()).Returns(DateTime.Parse(dateTime));
        var clock = new BusinessClockService(stubbedClock.Object);

        GetStatusResponse response = clock.GetCurrentStatus();

        Assert.True(response.Open);
    }

    [Theory]
    [InlineData("6/19/2023 8:59:00 AM")]
    [InlineData("6/19/2023 5:00:00 PM")]
    public void ClosedTimes(string dateTime)
    {
        var stubbedClock = new Mock<ISystemTime>();
        stubbedClock.Setup(c => c.GetCurrent()).Returns(DateTime.Parse(dateTime));
        var clock = new BusinessClockService(stubbedClock.Object);

        GetStatusResponse response = clock.GetCurrentStatus();

        Assert.True(response.Open);
    }
}
