using System;
using System.Linq;
using Azihub.GlobalData.Base.TopLevelDomain;
using Azihub.GlobalData.Base.TopLevelDomain.Tools;
using Azihub.Utilities.Base.Tests;
using Xunit;
using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests.Country
{
    public class CodeGenerationTests : TestBase
    {
        public CodeGenerationTests(ITestOutputHelper output) : base(output) { }

        private const string TLD_SAMPLES = @"# Version 2021071200, Last Updated Mon Jul 12 07:07:02 2021 UTC
COM
NET
ORG
INT
EDU
MIL";

        [Fact]
        public void FetchTopLevelDomainsTest()
        {
            IanaOrgTlds ianaOrgTlds = TldDataUpdater.FetchTlds();
            Output.WriteLine($"Fetched {ianaOrgTlds.List.Count} items");
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
            IanaOrgTlds tldHash = CodeSignatureService.GetIanaOrgTldsFromJson();
            Assert.Equal(64, tldHash.Hash.Length);
            Assert.True(tldHash.Count > 0);
            Assert.True(!String.IsNullOrEmpty(tldHash.Body));
        }

        // Uncomment below to test save
        [Fact]
        public void SaveCodeSignatureTest()
        {
            IanaOrgTlds tldHash = new(TLD_SAMPLES);
            CodeSignatureService.SaveIanaOrgTldsToJson(tldHash, false);
        }

        [Fact]
        public void CodeGenerationTest()
        {
            IanaOrgTlds ianaOrgTlds = new(TLD_SAMPLES);
            (string consts, string dict) = CodeGenerator.GenCodes(ianaOrgTlds);
            Output.WriteLine($"Consts:\n{consts}\n\n");
            Output.WriteLine($"Dict:\n{dict}");
        }
        
        [Fact]
        public void CodeGenerateUpdateNeededTest()
        {
            IanaOrgTlds tldHash = CodeSignatureService.GetIanaOrgTldsFromJson();
            IanaOrgTlds tldLatest = TldDataUpdater.FetchTlds();

#if DEBUG
            TldDataUpdater tldDataUpdater = new(Output.BuildLoggerFor<TldDataUpdater>());
            tldDataUpdater.Rebuild();
#endif   
            Assert.Equal(tldHash.Hash, tldLatest.Hash);
        }
    }
}