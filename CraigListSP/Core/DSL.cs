using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraigListSP.Core  
{
    public class DSL : VariaveisGlobais
    {
        public void Digite (string xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }

        public void Clique (string element)
        {
            driver.FindElement(By.XPath(element)).Click();
        }
        public void Aguarde()
        {
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }
        public void FecharTela()
        {
           driverQuit = true;
        }
    }
}
