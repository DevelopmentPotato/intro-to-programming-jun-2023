using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeter.UnitTests
{
    public class BadNamesTests
    {
        [Theory]
        [InlineData("Jayden" ,"Buffy")]
        public void censurData(params string[] names)
        {
            var badNames = new BadNames(names);
            List<string> expected = new();
            expected.Add("J****n");
            expected.Add("B***y");
            List<string> results = badNames.editBadNames(names);
            Assert.Equal(expected, results);

        }
    }
}
