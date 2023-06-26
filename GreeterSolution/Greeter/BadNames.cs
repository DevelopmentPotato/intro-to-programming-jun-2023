using System.Linq;

namespace Greeter;

public class BadNames : ICanRemoveBadNames
{

    private List<string> _badNames = new List<string>();
    public BadNames(params string[] badNames)
    {
        _badNames = badNames.ToList();
    }

    public List<string> editBadNames(params string[] names)
    {

        for (int i = 0; i < names.Length; i++)
        {
            
            if (_badNames.Any(n => n == names[i]))
            {
                string sign = "*";
                string placeholder = "";
                for (int j = 0; j < names[i].Length - 2; j++)
                {
                    placeholder += sign;
                }

                string ans = names[i][0].ToString();
                ans += placeholder;
                int len = names[i].Length;
                ans += names[i][names[i].Length -1];
                names[i] = ans;
            }
        }
        return names.ToList();
    }

}
