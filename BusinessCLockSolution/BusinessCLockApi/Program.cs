using BusinessCLockApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/status", () =>
{
    /*var timeToConvert = DateTime.Now;
    var est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
    var targetTime = TimeZoneInfo.ConvertTime(timeToConvert, est);
    List<String> weekDays = new List<String>();
    weekDays.Add("Monday");
    weekDays.Add("Tuesday");
    weekDays.Add("Wednesday");
    weekDays.Add("Thursday");
    weekDays.Add("Friday");
    TimeSpan now = DateTime.Now.TimeOfDay;
    TimeSpan start = new TimeSpan(9, 00, 0); //10 o'clock
    TimeSpan end = new TimeSpan(17, 0, 0);
    if ((now > start) && (now < end) && weekDays.Contains(targetTime.DayOfWeek.ToString()))
    {
        var response = new { open = true };
        return Results.Ok(response);
    }else if(targetTime.DayOfWeek.ToString() == "Saturday"){
    }
    else if(now < start)//openAt
    {
        var response = new { open = false, opensAt = start.ToString()  };
        return Results.Ok(reponse);
    }
    else if(now > end)//closedAt
    {
        var response = new { open = false, opensAt = end.ToString() };
        return Results.Ok(reponse);
    }
    */
    var response = new GetStatusResponse() { 
        Open = true
    };
    return Results.Ok(response);

}
);

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
