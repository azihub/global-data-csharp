using Azihub.GlobalData.Base.Networking.MediaTypes;
using Azihub.Utilities.Base.Tests;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests.Networking.MediaTypes
{
    public class MediaTypesTests : TestBase
    {

        public MediaTypesTests(ITestOutputHelper outputHelper) : base(outputHelper) { }

        [Theory]
        [InlineData("application/json","json")]
        [InlineData("text/plain","txt")]
        public void TestGetMediaTypeFromString(string code, string expectedExtension)
        {
            MediaType mediaType = MediaType.FromString(code);

            Output.WriteLine($"MediaType {code} has extension:" + mediaType.Extensions.First(x => x.Contains(expectedExtension)));
            Assert.Equal(expectedExtension, mediaType.Extensions.First(x => x.Contains(expectedExtension)));
        }
    }
}
