using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumPractice.SeleniumBasics
{
    class DriverCommands
    {
        [Test]
        public void PracticeExercise1()
        {
            //Initiate the Web driver - Launch a new Firefox browser.
            IWebDriver driver = new FirefoxDriver(@"c:\driver\");

            // Open Store.DemoQA.com
            driver.Url = ("http://www.demoqa.com/");

            // Get Page Title name and Title length - Store the page title inside 'Title'
            String Title = driver.Title;

            // Get Page Title Length and store the value as an int
            int TitleLength = driver.Title.Length;

            // Printing Title name on Console
            Console.WriteLine($"The page title is : "+Title);

            // Printing Title length inside Console
            Console.WriteLine($"The page title length is : " + Title.Length);

            // Store the page URL
            String PageURL = driver.Url;

            // Something should happen here haha
            int URLLength = PageURL.Length;

            // Printing the page URL
            Console.WriteLine("The page URl is : " + PageURL);

            // Printing the URL length in Console
            Console.WriteLine("The page URL length is :" + URLLength);

            // Get the page source and store it
            String PageHTML = driver.PageSource;

            // Get the length of HTML
            int HTMLLength = PageHTML.Length;

            // Print out the page source
            Console.WriteLine("This is the page source : " + PageHTML);

            // Print out the length of page source
            Console.WriteLine("This is the length of the page source : " + HTMLLength);
                        
            // Quite the driver
            driver.Quit();
        }







    }
}
