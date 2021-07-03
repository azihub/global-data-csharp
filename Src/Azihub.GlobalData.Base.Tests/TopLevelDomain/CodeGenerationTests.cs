using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using Azihub.GlobalData.Base.Tests.Abstract;
using Azihub.GlobalData.Base.TopLevelDomain;
using Azihub.GlobalData.Base.TopLevelDomain.Tools;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests
{
    public class CodeGenerationTests : TestBase
    {
        public CodeGenerationTests(ITestOutputHelper output) : base(output) { }

        [Fact]
        public void FetchTopLevelDomainsTest()
        {
            IEnumerable<string> list = TldDataUpdater.FetchTlds();
            Output.WriteLine($"Fetched {list.Count()} items");
            Assert.True(condition: list.Any());
            Assert.Contains(list, x => x == "COM");
            Assert.Contains(list, x => x == "NET");
            Assert.Contains(list, x => x == "ORG");
            Assert.Contains(list, x => x == "EDU");
            Assert.Contains(list, x => x == "GOV");
            Assert.Contains(list, x => x == "MIL");
        }

        [Fact]
        public void GetCodeSignatureTest()
        {
            TldAlphaByDomainHash tldHash = CodeSignatureService.GetSignatures();
            Assert.Equal(64, tldHash.Hash.Length);
        }
    }
}