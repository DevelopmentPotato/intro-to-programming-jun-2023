using Alba;
using BusinessCLockApi.Models;
using System.Net;

namespace BusinessClock.IntegrationTests.Status;

public class GettingTheStatus
{
    [Fact]
    public async Task OpenHours()
    {
        /*HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:1337");
        HttpResponseMessage response = await client.GetAsync("/status");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);*/

        var host = await AlbaHost.For<Program>();

        var response = await host.Scenario(api =>
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk();
            //api.StatusCodeShouldBe(404);
        });

        Assert.NotNull(response);
        GetStatusResponse? responseMessage = response.ReadAsJson<GetStatusResponse>();
        Assert.NotNull(responseMessage);
        Assert.True(responseMessage.Open);
        Assert.Null(responseMessage.OpensAt);
    }

    [Fact]
    public async Task ClosedHours()
    {

        var host = await AlbaHost.For<Program>();

        var response = await host.Scenario(api =>
        {
            api.Get.Url("/status");
            api.StatusCodeShouldBeOk();
            //api.StatusCodeShouldBe(404);
        });

        Assert.NotNull(response);
        GetStatusResponse? responseMessage = response.ReadAsJson<GetStatusResponse>();
        Assert.NotNull(responseMessage);
        Assert.False(responseMessage.Open);
        Assert.Null(responseMessage.OpensAt);
    }
}
