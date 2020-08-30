using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.EnumExtensions.UnitTest
{
    [TestClass]
    public class DescriptionExtensionTest
    {
        [TestMethod]
        public void Description()
        {
            Assert.AreEqual("Option01", SampleEnum.Option01.Description());
            Assert.AreEqual("Option 02", SampleEnum.Option02.Description());
        }

        private enum SampleEnum
        {
            Option01,

            [System.ComponentModel.Description("Option 02")]
            Option02
        }
    }
}