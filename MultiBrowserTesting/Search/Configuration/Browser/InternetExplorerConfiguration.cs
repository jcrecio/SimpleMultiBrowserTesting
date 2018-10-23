namespace MultiBrowserTesting
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.IE;

    [Category("InternetExplorer")]
    [TestFixture]
    public class InternetExplorerConfiguration : SearchTests
    {
        public override IWebDriver GetWebDriver()
        {
            return new InternetExplorerDriver();
        }
    }
}