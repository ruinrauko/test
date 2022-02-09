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
public class EtiketTanmlamaTest {
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
  public void etiketTanmlama() {
    // Test name: Etiket Tanımlama
    // Step # | name | target | value
    // 1 | open | / | 
    driver.Navigate().GoToUrl("https://cms.memorial.4alabs.com/");
    // 2 | setWindowSize | 1752x840 | 
    driver.Manage().Window.Size = new System.Drawing.Size(1752, 840);
    // 3 | click | linkText=Tanımlamalar | 
    driver.FindElement(By.LinkText("Tanımlamalar")).Click();
    // 4 | click | linkText=Etiket İşlemleri | 
    driver.FindElement(By.LinkText("Etiket İşlemleri")).Click();
    // 5 | click | linkText=Etiket Listesi | 
    driver.FindElement(By.LinkText("Etiket Listesi")).Click();
    // 6 | click | linkText=Ekle | 
    driver.FindElement(By.LinkText("Ekle")).Click();
    // 7 | click | id=ticketName | 
    driver.FindElement(By.Id("ticketName")).Click();
    // 8 | type | id=ticketName | selenium test
    driver.FindElement(By.Id("ticketName")).SendKeys("selenium test");
    // 9 | click | css=.filter-option | 
    driver.FindElement(By.CssSelector(".filter-option")).Click();
    // 10 | click | linkText=Evde Doktor | 
    driver.FindElement(By.LinkText("Evde Doktor")).Click();
    // 11 | addSelection | id=cmbCategorie | label=Evde Doktor
    {
      var dropdown = driver.FindElement(By.Id("cmbCategorie"));
      dropdown.FindElement(By.XPath("//option[. = 'Evde Doktor']")).Click();
    }
    // 12 | click | linkText=Evde Görüntüleme | 
    driver.FindElement(By.LinkText("Evde Görüntüleme")).Click();
    // 13 | addSelection | id=cmbCategorie | label=Evde Görüntüleme
    {
      var dropdown = driver.FindElement(By.Id("cmbCategorie"));
      dropdown.FindElement(By.XPath("//option[. = 'Evde Görüntüleme']")).Click();
    }
    // 14 | click | linkText=Evde Hemşire | 
    driver.FindElement(By.LinkText("Evde Hemşire")).Click();
    // 15 | addSelection | id=cmbCategorie | label=Evde Hemşire
    {
      var dropdown = driver.FindElement(By.Id("cmbCategorie"));
      dropdown.FindElement(By.XPath("//option[. = 'Evde Hemşire']")).Click();
    }
    // 16 | click | linkText=Laboratuvar Paketi | 
    driver.FindElement(By.LinkText("Laboratuvar Paketi")).Click();
    // 17 | addSelection | id=cmbCategorie | label=Laboratuvar Paketi
    {
      var dropdown = driver.FindElement(By.Id("cmbCategorie"));
      dropdown.FindElement(By.XPath("//option[. = 'Laboratuvar Paketi']")).Click();
    }
    // 18 | click | linkText=Laboratuvar Paketi | 
    driver.FindElement(By.LinkText("Laboratuvar Paketi")).Click();
    // 19 | removeSelection | id=cmbCategorie | label=Laboratuvar Paketi
    {
      var dropdown = driver.FindElement(By.Id("cmbCategorie"));
      dropdown.FindElement(By.XPath("//option[. = 'Laboratuvar Paketi']")).Click();
    }
    // 20 | click | css=.container-fluid | 
    driver.FindElement(By.CssSelector(".container-fluid")).Click();
    // 21 | click | id=ckFilter | 
    driver.FindElement(By.Id("ckFilter")).Click();
    // 22 | click | id=ckInterest | 
    driver.FindElement(By.Id("ckInterest")).Click();
    // 23 | click | css=.btn-info | 
    driver.FindElement(By.CssSelector(".btn-info")).Click();
    // 24 | click | css=.swal-button | 
    driver.FindElement(By.CssSelector(".swal-button")).Click();
  }
}
