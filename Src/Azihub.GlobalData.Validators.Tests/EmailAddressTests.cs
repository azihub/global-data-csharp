using System.Net.Mail;
using Azihub.Utilities.Base.Tests;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Validators.Tests
{
    public class EmailAddressTests : TestBase
    {
        public EmailAddressTests(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void GetEmailAddressTest()
        {
            string email = "a@b.c";
            MailAddress testResult = EmailAddress.GetEmailAddress(email);
            Assert.Equal(email, testResult.Address);
        }

        [Theory]
        [InlineData("a@b.c", false)]
        [InlineData("a@b.com", true)]
        public void IsValidEmailAddress(string email, bool expectedResult)
        {
            bool testResult = EmailAddress.IsValidEmailAddress(email);
            Output.WriteLine($"Running test on: {email} => Test result: {testResult} | Expected: {expectedResult}");
            Assert.Equal(expectedResult, testResult);
        }
    }
}
