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
public class LogOutTest {
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
  public void logOut() {
    // Test name: Log Out
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("https://cms.memorial.4alabs.com/");
    // 2 | setWindowSize | 1752x1000 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1752, 1000);
    // 3 | click | css=.profile-pic | 
    driver.FindElement(By.CssSelector(".profile-pic")).Click();
    // 4 | click | linkText=Çıkış Yap | 
    driver.FindElement(By.LinkText("Çıkış Yap")).Click();
    // 5 | type | id=Email | ugur.kucukgedik@4alabs.io
    driver.FindElement(By.Id("Email")).SendKeys("ugur.kucukgedik@4alabs.io");
    // 6 | type | id=Password | 123456.
    driver.FindElement(By.Id("Password")).SendKeys("123456.");
  }
}
