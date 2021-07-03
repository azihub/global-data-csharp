using Azihub.GlobalData.Base.Tests.Abstract;
using Azihub.GlobalData.Base.TopLevelDomain;
using Azihub.GlobalData.Base.TopLevelDomain.Exceptions;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests.TopLevelDomain
{
    public class TopLevelDomainTests : TestBase
    {
        public TopLevelDomainTests(ITestOutputHelper output) : base(output) { }
        
        [Theory]
        [InlineData("COM")]
        [InlineData("net")]
        [InlineData("org")]
        [InlineData("gov")]
        public void ValidateTldTest(string tldStr)
        {
            Tld tld = Tld.FromString(tldStr);
            Output.WriteLine($"Expected: {tldStr}, Output: {tld.Value}");
            Assert.Equal(tldStr.ToLower(), tld.Value);
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
