using Azihub.GlobalData.Banking.Banks;
using Azihub.GlobalData.Base.Country;
using Azihub.Utilities.Base.Tests;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Banking.Tests
{
    public class BicTests : TestBase
    {
        public BicTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }

        [Fact]
        public void BicTestSample()
        {
            BicCode cimbBicCode = BicCode.FromString(BicCodesConsts.MY_CIMB_KL);

            Assert.Equal("CIBBMYKL", cimbBicCode.Code);
            Assert.Equal(CountryIso2Code.Malaysia, cimbBicCode.CountryCode);
        }

        [Fact]
        public void BankTestSample()
        {
            
        }


    }
}
