using Azihub.GlobalData.Base.TopLevelDomain;
using Azihub.GlobalData.Base.TopLevelDomain.Exceptions;
using Xunit;
using Xunit.Abstractions;
using TestBase = Azihub.Utilities.Base.Tests.TestBase;

namespace Azihub.GlobalData.Base.Tests.TopLevelDomain
{
    public class TopLevelDomainTests : TestBase
    {
        public TopLevelDomainTests(ITestOutputHelper output) : base(output) { }
        
        [Theory]
        [InlineData("COM", TldConsts.COM)]
        [InlineData("net", TldConsts.NET)]
        [InlineData("org", TldConsts.ORG)]
        [InlineData("gov", TldConsts.GOV)]
        public void ValidateTldTest(string tldStr, string expected)
        {
            Tld tld = Tld.FromString(tldStr);
            Output.WriteLine($"Expected: {tldStr}, Output: {tld.Code}");
            Assert.Equal(expected, tld.Code);
        }

        [Fact]
        public void InvalidTldTest()
        {
            Assert.Throws<InvalidTopLevelDomainException>(
                () => Tld.FromString("DOESNOTEXISTS")
                );
        }
    }
}
