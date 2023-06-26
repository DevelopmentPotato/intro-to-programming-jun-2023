namespace Greeter
{
    public interface ICanRemoveBadNames
    {
        List<string> editBadNames(params string[] names);
    }
}