using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TeamCityTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://metanit.com/");

            IWebElement searchInput = driver.FindElement(By.CssSelector("div.magnifying-glass"));
            IWebElement searchButton = driver.FindElement(By.Id("searchInputButton"));
            IWebElement firstHeader = driver.FindElement(By.CssSelector("ul.archive-list>li>h4>a"));

            searchInput.Click();
            searchInput.SendKeys("c#");
            
            //string firstHeaderText = firstHeader.Text;

            //string firstHeaderHardText = "C# docs - get started, tutorials, reference. | Microsoft Docs";

            //Assert.AreEqual(firstHeaderText, firstHeaderHardText);
        }
    }
}
