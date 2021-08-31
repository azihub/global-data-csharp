using Azihub.GlobalData.Banking.Banks;
using Azihub.Utilities.Base.Tests;
using System;
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
        }

        [Fact]
        public void BankTestSample()
        {
            
        }


    }
}
