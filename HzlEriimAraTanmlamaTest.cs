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
public class HzlEriimAraTanmlamaTest {
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
  public void hzlEriimAraTanmlama() {
    // Test name: Hızlı Erişim Araç Tanımlama
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("https://cms.memorial.4alabs.com/");
    // 2 | setWindowSize | 1752x1000 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1752, 1000);
    // 3 | click | linkText=Tanımlamalar | 
    driver.FindElement(By.LinkText("Tanımlamalar")).Click();
    // 4 | click | linkText=Hızlı Erişim Araç | 
    driver.FindElement(By.LinkText("Hızlı Erişim Araç")).Click();
    // 5 | click | linkText=Hızlı Erişim Araç Liste | 
    driver.FindElement(By.LinkText("Hızlı Erişim Araç Liste")).Click();
    // 6 | click | linkText=Ekle | 
    driver.FindElement(By.LinkText("Ekle")).Click();
    // 7 | click | id=ToolOrder | 
    driver.FindElement(By.Id("ToolOrder")).Click();
    // 8 | type | id=ToolOrder | 555
    driver.FindElement(By.Id("ToolOrder")).SendKeys("555");
    // 9 | click | id=InterfaceTypeId | 
    driver.FindElement(By.Id("InterfaceTypeId")).Click();
    // 10 | select | id=InterfaceTypeId | label=Kurumsal
    {
      var dropdown = driver.FindElement(By.Id("InterfaceTypeId"));
      dropdown.FindElement(By.XPath("//option[. = 'Kurumsal']")).Click();
    }
    // 11 | click | id=ButtonName | 
    driver.FindElement(By.Id("ButtonName")).Click();
    // 12 | type | id=ButtonName | selenium test
    driver.FindElement(By.Id("ButtonName")).SendKeys("selenium test");
    // 13 | click | id=RedirectTypeId | 
    driver.FindElement(By.Id("RedirectTypeId")).Click();
    // 14 | select | id=RedirectTypeId | label=Uygulama Içi Yönlendirme
    {
      var dropdown = driver.FindElement(By.Id("RedirectTypeId"));
      dropdown.FindElement(By.XPath("//option[. = 'Uygulama Içi Yönlendirme']")).Click();
    }
    // 15 | click | id=MobilePageId | 
    driver.FindElement(By.Id("MobilePageId")).Click();
    // 16 | select | id=MobilePageId | label=Sayfa 2
    {
      var dropdown = driver.FindElement(By.Id("MobilePageId"));
      dropdown.FindElement(By.XPath("//option[. = 'Sayfa 2']")).Click();
    }
    // 17 | click | id=DocumentBase64 | 
    driver.FindElement(By.Id("DocumentBase64")).Click();
    // 18 | type | id=DocumentBase64 | C:\Users\4A Labs\Desktop\Memorial\hakkında jpg.jfif
    driver.FindElement(By.Id("DocumentBase64")).SendKeys("C:\\Users\\4A Labs\\Desktop\\Memorial\\hakkında jpg.jfif");
    // 19 | click | id=IsActive | 
    driver.FindElement(By.Id("IsActive")).Click();
    // 20 | click | css=.btn-info | 
    driver.FindElement(By.CssSelector(".btn-info")).Click();
    // 21 | click | css=.swal-button | 
    driver.FindElement(By.CssSelector(".swal-button")).Click();
  }
}
