namespace MultiBrowserTesting
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    [Category("Chrome")]
    [TestFixture]
    public class ChromeConfiguration : SearchTests
    {
        public override IWebDriver GetWebDriver()
        {
            return new ChromeDriver();
        }
    }
}