using Xunit.Abstractions;

namespace Azihub.GlobalData.Base.Tests.Abstract
{
    public abstract class TestBase
    {
        protected ITestOutputHelper Output { get; }

        public TestBase(ITestOutputHelper outputHelper)
        {
            Output = outputHelper;
        }


    }
}
