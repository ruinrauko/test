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
public class SzlemeTanmlamaTest {
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
  public void szlemeTanmlama() {
    // Test name: Sözleşme Tanımlama
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("https://cms.memorial.4alabs.com/");
    // 2 | setWindowSize | 1752x1000 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1752, 1000);
    // 3 | click | linkText=Tanımlamalar | 
    driver.FindElement(By.LinkText("Tanımlamalar")).Click();
    // 4 | click | linkText=Sözleşme İşlemleri | 
    driver.FindElement(By.LinkText("Sözleşme İşlemleri")).Click();
    // 5 | click | linkText=Sözleşme Listesi | 
    driver.FindElement(By.LinkText("Sözleşme Listesi")).Click();
    // 6 | click | linkText=Ekle | 
    driver.FindElement(By.LinkText("Ekle")).Click();
    // 7 | runScript | window.scrollTo(0,1.600000023841858) | 
    js.ExecuteScript("window.scrollTo(0,1.600000023841858)");
    // 8 | click | id=UserContractType | 
    driver.FindElement(By.Id("UserContractType")).Click();
    // 9 | select | id=UserContractType | label=ETK Metni
    {
      var dropdown = driver.FindElement(By.Id("UserContractType"));
      dropdown.FindElement(By.XPath("//option[. = 'ETK Metni']")).Click();
    }
    // 10 | click | css=.note-editable | 
    driver.FindElement(By.CssSelector(".note-editable")).Click();
    // 11 | editContent | css=.note-editable | <p>test selenium</p>
    {
      var element = driver.FindElement(By.CssSelector(".note-editable"));
      js.ExecuteScript("if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<p>test selenium</p>'}", element);
    }
    // 12 | click | css=.row > .btn | 
    driver.FindElement(By.CssSelector(".row > .btn")).Click();
    // 13 | click | css=.swal-button | 
    driver.FindElement(By.CssSelector(".swal-button")).Click();
  }
}
