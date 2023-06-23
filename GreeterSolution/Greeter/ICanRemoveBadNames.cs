namespace Greeter
{
    public interface ICanRemoveBadNames
    {
        List<string> excludeBadNames(List<string> names);
    }
}