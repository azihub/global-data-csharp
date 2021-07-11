using Azihub.GlobalData.Base.Validators;
using Xunit;

namespace Azihub.GlobalData.Base.Tests.Validators
{
    public class EmailValidationTests
    {
        [Theory]
        [InlineData("test@example.com", true)]
        [InlineData("test@example.coim", false)]
        public void ValidateEmailTest(string email, bool expected)
        {
            bool result = Email.IsValidEmailAddress(email);
            Assert.Equal(expected, result);
        }
    }
}
