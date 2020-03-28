using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutoTest.Control
{
    public class Table : BaseControl
    {
        public Table(IWebDriver _webDriver, IWebElement _rootElement) : base(_webDriver, _rootElement)
        {
        }

        public IEnumerable<Row> Rows
        {
            get
            {
                List<Row> rows = new List<Row>();

                foreach (var row in rootElement.FindElements(By.XPath(".//tbody/tr")))
                {
                    rows.Add(new Row(webDriver, row));
                }

                return rows;
            }
        }
    }
}
