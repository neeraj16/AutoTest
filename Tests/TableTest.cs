using AutoTest;
using AutoTest.Control;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{
    public class TableTest
    {
        [SetUp]
        public void Set()
        {

        }

        [Test]
        public void KendoTableOne()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.telerik.com/kendo-angular-ui/components/grid/how-to/filter-all-columns/");
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));
            wait.Until(r => r.FindElement(By.Id("example-filter-all-columns")));
            webDriver.SwitchTo().Frame(webDriver.FindElement(By.Id("example-filter-all-columns")));
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(50));
            wait.Until(r => r.FindElement(By.XPath("//input[@class='k-textbox']")));
            var kendoTable = new Table(webDriver, webDriver.FindElement(By.XPath(".//table[@class = 'k-grid-table']")));

            Console.WriteLine(kendoTable.Rows.Count());
            Console.WriteLine(kendoTable.Rows.FirstOrDefault().Cells().ElementAt(2).GetText());
        }

        [TearDown]
        public void Tear()
        {

        }

    }
}
