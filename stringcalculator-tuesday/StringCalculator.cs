
using Xunit.Sdk;

namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if(numbers == "")
        {
            return 0;
        }
        else if (numbers.Contains(','))
        {
            string[] nums;
            string temp = numbers.Substring(0, 2);
            if (numbers.Substring(0, 2).Equals("//"))
            {
                char customChar = numbers[2];
                nums = numbers.Substring(4).Split(',', customChar);
            }
            else
            {
                nums = numbers.Split(',', '\n');
            }

            
            int sum = 0;
            foreach(var num in nums)
            {
                sum += int.Parse(num);
            }
            return sum;
        }
        else
        {
            return int.Parse(numbers);
        }
        
    }
}
