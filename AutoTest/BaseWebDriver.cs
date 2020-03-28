using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTest
{
    public class BaseWebDriver
    {
        IWebDriver _baseWebDriver;

        public BaseWebDriver(IWebDriver webDriver)
        {
            _baseWebDriver = webDriver;
        }

        public string Title
        {
            get
            {
                return _baseWebDriver.Title;
            }
        }

        public string Url
        {
            get
            {
                return _baseWebDriver.Url;
            }
        }

        public string PageSource
        {
            get
            {
                return _baseWebDriver.PageSource;
            }
        }
    }
}
