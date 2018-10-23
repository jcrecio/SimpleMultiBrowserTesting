namespace MultiBrowserTesting
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using System.Configuration;

    public abstract class BaseTest
    {
        protected IWebDriver driver;

        public abstract IWebDriver GetWebDriver();

        [SetUp]
        public void Init()
        {
            driver = GetWebDriver();
        }

        [TearDown]
        public void Finish()
        {
            driver = null;
        }
    }
}