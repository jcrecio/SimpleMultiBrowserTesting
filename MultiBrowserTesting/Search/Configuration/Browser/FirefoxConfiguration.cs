namespace MultiBrowserTesting
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;

    [Category("Firefox")]
    [TestFixture]
    public class FirefoxConfiguration : SearchTests
    {
        public override IWebDriver GetWebDriver()
        {
            return new FirefoxDriver(
                    new FirefoxOptions
                    {
                        Profile = GetFirefoxProfile(),
                        AcceptInsecureCertificates = true
                    });
        }

        private FirefoxProfile GetFirefoxProfile()
        {
            FirefoxProfile profile = new FirefoxProfile();

            profile.SetPreference("network.http.phishy-userpass-length", 255);
            profile.SetPreference("network.automatic-ntlm-auth.trusted-uris", url);
            profile.SetPreference("webdriver_assume_untrusted_issuer", true);
            profile.SetPreference("trustAllSSLCertificates", true);

            return profile;
        }
    }
}