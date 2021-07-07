using Azihub.GlobalData.Base.Tests.Abstract;
using Azihub.GlobalData.Validators;
using System.Net.Mail;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.Utilities.Tests.Valitators
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
