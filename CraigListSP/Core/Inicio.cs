using NUnit;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CraigListSP.Core
{
    public class Inicio : DSL
    {

        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://saopaulo.craigslist.org");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driverQuit = false;

        }

        [TearDown]
        public void FimDoTeste()
        {
            if (driverQuit) driver.Quit();
        }
    }
}