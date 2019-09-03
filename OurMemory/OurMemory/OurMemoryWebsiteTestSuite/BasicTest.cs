using System.Collections.Generic;
using Xunit;

namespace OurMemoryWebsiteTestSuite
{
    public class BasicTestData
    {
        public static bool newBool = default;

        public static IEnumerable<object[]> Data =>

            new List<object[]>
            {
                new object[] { true, true },
                new object[] { newBool, false },
            };
    }

    public class BasicTest
    {
        [Theory]
        [MemberData(nameof(BasicTestData.Data), MemberType =typeof(BasicTestData))]
        public void FalseDefault(bool a, bool b)
        {
            Assert.Equal(a, b);
        }
    }
}
