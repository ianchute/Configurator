using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Configurator.Tests
{
    [TestClass]
    public class ConfiguratorTests
    {
        [TestMethod]
        public void ConfiguratorBasicUsageShouldWork()
        {
            SampleConfig config = Configurator.Configure<SampleConfig>("config");

            Assert.AreEqual(0.01, config.DoubleConfig);
            Assert.AreEqual(1, config.IntConfig);
            Assert.AreEqual('c', config.CharConfig);
            Assert.AreEqual("string", config.StringConfig);
        }
    }
}
