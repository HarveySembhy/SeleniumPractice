using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumPractice
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver(@"c:\driver\");            
        }        

        [Test]
        public void OpenApp()
        {
            driver.Url = "http://www.demoqa.com/"; 
            //In this area, you can test anything by adding the list of commands as test steps - hehe, super exciting
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
        
        //[SetUp]
        
        //public void OpenBrowser()
        //{
        //    driver.Url = "http://www.demoqa.com/";
        //}

        //[Test]

        //public void ClickTabs()
        //{
        //    driver.FindElement(By.Id("ui-id-2"));
        //            }

        //[TearDown]
    }
}
