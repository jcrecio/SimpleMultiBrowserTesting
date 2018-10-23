namespace MultiBrowserTesting
{
    using NUnit.Framework;

    /// <summary>
    /// These tests are run for all the browsers you configure
    /// See: ChromeConfiguration.cs, FirefoxConfiguration.cs, etc
    /// You can create another for instance: SafariConfiguration.cs to provide a new driver with GetWebDriver() method
    /// </summary>
    [TestFixture]
    [Category("Search")]
    public abstract class SearchTests : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            // my test things
        }

        [Test]
        public void TestMethod2()
        {
            // my test things
        }
    }
}