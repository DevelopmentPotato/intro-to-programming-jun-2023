namespace Greeter;

public class BadNames : ICanRemoveBadNames
{

    private List<string> _badNames = new List<string>();
    public BadNames(params string[] badNames)
    {
        _badNames = badNames.ToList();
    }

    public List<string> excludeBadNames(List<string> names)
    {
        foreach(string  badName in names.ToList().Intersect(_badNames))
        {
            string sign = "*"
            string placeholder = "";
            for(int i=0;i<badName.Length-2;i++)
            {
                placeholder += sign;
            }
            badName = badName.Substring(0,1) + placeholder + badName.Substring(badName.Length-1,badName.Length);
        }
        return names.ToList().Except(_badNames).ToList();
    }

}
