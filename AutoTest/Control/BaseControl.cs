using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest.Control
{
    public class BaseControl
    {
        protected IWebDriver webDriver;
        protected IWebElement rootElement;

        public BaseControl(IWebDriver _webDriver, IWebElement _rootElement)
        {
            webDriver = _webDriver;
            rootElement = _rootElement;
        }
    }
}
