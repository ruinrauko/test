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
public class RolTanmlamaTest {
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
  public void rolTanmlama() {
    // Test name: Rol Tanımlama
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("https://cms.memorial.4alabs.com/");
    // 2 | setWindowSize | 1752x1000 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1752, 1000);
    // 3 | click | linkText=Tanımlamalar | 
    driver.FindElement(By.LinkText("Tanımlamalar")).Click();
    // 4 | click | linkText=Rol İşlemleri | 
    driver.FindElement(By.LinkText("Rol İşlemleri")).Click();
    // 5 | click | linkText=Rol Ekle | 
    driver.FindElement(By.LinkText("Rol Ekle")).Click();
    // 6 | click | id=Name | 
    driver.FindElement(By.Id("Name")).Click();
    // 7 | type | id=Name | Selenium Create
    driver.FindElement(By.Id("Name")).SendKeys("Selenium Create");
    // 8 | click | id=Description | 
    driver.FindElement(By.Id("Description")).Click();
    // 9 | mouseOver | css=.btn-info | 
    {
      var element = driver.FindElement(By.CssSelector(".btn-info"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    // 10 | type | id=Description | test
    driver.FindElement(By.Id("Description")).SendKeys("test");
    // 11 | click | css=.btn-info | 
    driver.FindElement(By.CssSelector(".btn-info")).Click();
    // 12 | mouseOut | css=.btn-info | 
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    // 13 | click | css=.swal-button | 
    driver.FindElement(By.CssSelector(".swal-button")).Click();
  }
}
