using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutoTest.Control
{
    public class Row : BaseControl
    {
        public Row(IWebDriver _webDriver, IWebElement _rootElement) : base(_webDriver, _rootElement)
        {
        }

        public IEnumerable<Cell> Cells()
        {
            List<Cell> cells = new List<Cell>();

            foreach (var cell in rootElement.FindElements(By.XPath("")))
            {
                cells.Add(new Cell(webDriver, cell));
            }

            return cells;
        }
    }
}
