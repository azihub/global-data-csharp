using Azihub.Utilities.Base.Tests;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Validators.Tests
{
    public class MobileTests : TestBase
    {
        public MobileTests(ITestOutputHelper output) : base(output) { }

        [Theory]
        [InlineData(16156182211, true)]   // US Mobile or Landline
        [InlineData(161561822, false)]   // US Mobile or Landline (Invalid)
        [InlineData(60121234567, true)]  // Malaysia Mobile
        [InlineData(601212345678, false)]  // Malaysia Mobile (Invalid)
        [InlineData(989121234567, true)]  // Iran Mobile
        [InlineData(98912123, false)]  // Iran Mobile (Invalid)
        [InlineData(31612345678, true)]  // Netherlands Mobile
        [InlineData(31203690388, false)]  // Netherlands Landline
        public void MobileValidationTest(ulong mobile, bool expectedResult)
        {
            bool testResult = MobileNumber.IsValidMobileNumber(mobile);
            Output.WriteLine($"Tested Mobile: {mobile} => Test result: {testResult} | Expected result: {expectedResult} ");
            Assert.Equal(expectedResult, testResult);
        }
    }
}
