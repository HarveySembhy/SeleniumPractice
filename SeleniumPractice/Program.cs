using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumPractice
{
    class BasicTest
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver(@"C:\driver");
            {
                driver.Url = "http://www.demoqa.com/";
            }

            
            
        }
    }
}
