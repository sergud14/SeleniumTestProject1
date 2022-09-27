namespace SeleniumTestProject1
{
    public class Tests
    {
            private IWebDriver driver;
            
            [SetUp]
            public void Setup()
            {
            driver = new ChromeDriver();
            }

            [Test]
            public void Test1()
            {
            driver.Navigate().GoToUrl(@"https://dzen.ru/");
            }

            [TearDown]
            public void stop()
            {
                driver.Quit();
                driver = null;
            }
    }
}