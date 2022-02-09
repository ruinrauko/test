// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class HastaneListesiTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void hastaneListesi() {
    // Test name: Hastane Listesi
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("https://cms.memorial.4alabs.com/");
    // 2 | setWindowSize | 1752x1000 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1752, 1000);
    // 3 | click | linkText=Tanımlamalar | 
    driver.FindElement(By.LinkText("Tanımlamalar")).Click();
    // 4 | click | linkText=Hastane İşlemleri | 
    driver.FindElement(By.LinkText("Hastane İşlemleri")).Click();
    // 5 | click | linkText=Hastane Listesi | 
    driver.FindElement(By.LinkText("Hastane Listesi")).Click();
    // 6 | runScript | window.scrollTo(0,2.4000000953674316) | 
    js.ExecuteScript("window.scrollTo(0,2.4000000953674316)");
    // 7 | click | css=th:nth-child(3) > .column_search | 
    driver.FindElement(By.CssSelector("th:nth-child(3) > .column_search")).Click();
    // 8 | type | css=th:nth-child(3) > .column_search | ata
    driver.FindElement(By.CssSelector("th:nth-child(3) > .column_search")).SendKeys("ata");
    // 9 | click | css=.fa-arrow-up | 
    driver.FindElement(By.CssSelector(".fa-arrow-up")).Click();
    // 10 | click | css=th:nth-child(3) > .column_search | 
    driver.FindElement(By.CssSelector("th:nth-child(3) > .column_search")).Click();
    // 11 | type | css=th:nth-child(3) > .column_search | ata
    driver.FindElement(By.CssSelector("th:nth-child(3) > .column_search")).SendKeys("ata");
    // 12 | click | css=.fa-arrow-down | 
    driver.FindElement(By.CssSelector(".fa-arrow-down")).Click();
    // 13 | click | css=th:nth-child(3) > .column_search | 
    driver.FindElement(By.CssSelector("th:nth-child(3) > .column_search")).Click();
    // 14 | type | css=th:nth-child(3) > .column_search | ata
    driver.FindElement(By.CssSelector("th:nth-child(3) > .column_search")).SendKeys("ata");
    // 15 | click | css=.lever | 
    driver.FindElement(By.CssSelector(".lever")).Click();
    // 16 | click | css=.align-middle > .btn-info | 
    driver.FindElement(By.CssSelector(".align-middle > .btn-info")).Click();
    // 17 | runScript | window.scrollTo(0,1.600000023841858) | 
    js.ExecuteScript("window.scrollTo(0,1.600000023841858)");
    // 18 | click | linkText=Liste | 
    driver.FindElement(By.LinkText("Liste")).Click();
    // 19 | click | css=th:nth-child(3) > .column_search | 
    driver.FindElement(By.CssSelector("th:nth-child(3) > .column_search")).Click();
    // 20 | type | css=th:nth-child(3) > .column_search | ata
    driver.FindElement(By.CssSelector("th:nth-child(3) > .column_search")).SendKeys("ata");
    // 21 | click | css=.lever | 
    driver.FindElement(By.CssSelector(".lever")).Click();
  }
}