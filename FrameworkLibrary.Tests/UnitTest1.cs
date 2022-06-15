using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace FrameworkLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldTest_NonAsyncMethod()
        {
            var fccClass = new FccClass();
            var actual = fccClass.NonAsyncMethod();

            Assert.IsNotNull(actual);
        }
        [TestMethod]
        public async Task ShouldTest_AsyncMethod()
        {
            var fccClass = new FccClass();
            var actual = await fccClass.AsyncMethod();

            Assert.IsNotNull(actual);
        }
    }
}
