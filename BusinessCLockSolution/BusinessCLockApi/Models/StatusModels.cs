namespace BusinessCLockApi.Models;

public class GetStatusResponse
{
    public bool Open { get; init; }
    public DateTime? OpensAt { get; init; }
}
