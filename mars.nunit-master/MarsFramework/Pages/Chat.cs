using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class Chat
    {
        private RemoteWebDriver _driver;
        public Chat(RemoteWebDriver driver) => _driver = driver;

        //Click on 'Chat' LinkText 
        IWebElement OpenChat => _driver.FindElementByCssSelector("div div.ui.secondary.menu div.right.item div > a:nth-child(2)");

        #region Search Skills on Sub Categories 
        public void ClickChat()
        {
            #region Navigate to Search Skills icon
            //Click on Search Skills icon
            OpenChat.Click();

        } 
        #endregion

    }
}
#endregion