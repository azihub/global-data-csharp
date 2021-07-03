using System;
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
            IanaOrgTlds ianaOrgTlds = TldDataUpdater.FetchTlds();
            Output.WriteLine($"Fetched {ianaOrgTlds.List.Count()} items");
            Assert.True(condition: ianaOrgTlds.List.Any());
            Assert.Contains(ianaOrgTlds.List, x => x == "COM");
            Assert.Contains(ianaOrgTlds.List, x => x == "NET");
            Assert.Contains(ianaOrgTlds.List, x => x == "ORG");
            Assert.Contains(ianaOrgTlds.List, x => x == "EDU");
            Assert.Contains(ianaOrgTlds.List, x => x == "GOV");
            Assert.Contains(ianaOrgTlds.List, x => x == "MIL");
        }

        [Fact]
        public void GetCodeSignatureTest()
        {
            IanaOrgTlds tldHash = CodeSignatureService.GetIanaTldsFromJson();
            Assert.Equal(64, tldHash.Hash.Length);
            Assert.True(tldHash.Count > 0);
            Assert.True( ! String.IsNullOrEmpty(tldHash.Body) );
        }
    }
}