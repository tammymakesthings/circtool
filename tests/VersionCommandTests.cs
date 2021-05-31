using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.tammymakesthings.circtool;
using com.tammymakesthings.circtool.handlers;

namespace com.tammymakesthings.circtool.tests
{
    [TestClass]
    public class VersionCommandTests
    {
        [TestMethod]
        public void VersionCommandReturnsCorrectOutput()
        {
            VersionHandler h = new VersionHandler(false);
            string[] output = h.HandleCommand().Split('\n');
            Assert.IsNotNull(output);
            Assert.AreEqual(4, output.Length);
            Assert.AreEqual(String.Format("circtool {0} - {1}",
                com.tammymakesthings.circtool.lib.Version.APP_VERSION,
                com.tammymakesthings.circtool.lib.Version.APP_DATE.ToShortDateString()
                ), output[0]);
        }
    }
}
