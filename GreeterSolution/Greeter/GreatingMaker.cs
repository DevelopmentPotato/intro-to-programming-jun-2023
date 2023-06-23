namespace Greeter
{
    public class GreetingMaker
    {
        private readonly ICanRemoveBadNames _badNames;
        public GreetingMaker(ICanRemoveBadNames badNames)
        {
            _badNames = badNames;
        }


        public string Greet(params string[] names)
        {
            if(names == null)
            {
                return "Sup Doc!";
            }

            List<string> lowerNames = new List<string>();
            List<string> upperNames = new List<string>();

            List<string> splitNames = SplitNames(names);
            
            foreach(string name in splitNames)
            {
                if(name == name.ToUpper())
                {
                    upperNames.Add(name);
                }
                else
                {
                    lowerNames.Add(name);
                }
            }


            string greet = "Hello,";
            if(lowerNames.Count == 0)
            {
                greet = greet.ToUpper();
            }

            lowerNames.AddRange(upperNames);//lower names is now an ordered list

            

            for (int i=0;i<lowerNames.Count;i++)
            {
                if(i == lowerNames.Count - 1 && i!=0)
                {
                    if(upperNames.Count > 0)
                    {
                        greet += " AND";
                    }
                    else
                    {
                        greet += " and";
                    }
                    
                }

                if(i == lowerNames.Count - 1)
                {
                    greet += " " + lowerNames[i] + "!";
                }
                else
                {
                    greet += " " + lowerNames[i] + ",";
                }
                
            }

            if (names.Length == 1 && names[0] == names[0].ToUpper())
            {
                greet = greet.ToUpper();
            }

            return greet;
        }

        private List<string> SplitNames(string[] names)
        {
            List<string> splitNames = new List<string>();
            foreach(string name in names)
            {
                if (name.Contains(","))
                {
                    var SpaceReplacedName = name.Replace(" ", "");
                    var temp = SpaceReplacedName.Split(",");
                    foreach(string tempName in temp)
                    {
                        splitNames.Add(tempName);
                    }

                }
                else
                {
                    splitNames.Add(name);
                }
            }
            return splitNames;
        }
    }
}