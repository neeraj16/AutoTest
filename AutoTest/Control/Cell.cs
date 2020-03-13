using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutoTest.Control
{
    public class Cell : BaseControl
    {
        public Cell(IWebDriver _webDriver, IWebElement _rootElement) : base(_webDriver, _rootElement)
        {
        }

        public string GetText()
        {
            return rootElement.Text;
        }
    }
}
