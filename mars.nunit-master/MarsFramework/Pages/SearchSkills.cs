using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    internal class SearchSkills
    {
        private RemoteWebDriver _driver;
        public SearchSkills(RemoteWebDriver driver) => _driver = driver;

        //Click on 'SearchSkills' icon 
        IWebElement SearchSkill => _driver.FindElementByCssSelector("div div.ui.secondary.menu div.ui.small.icon.input.search-box > i");

        //Click on 'AllCategories' icon        
        IWebElement AllCategories => _driver.FindElementByCssSelector("div.ui.container div section div div.four.wide.column div:nth-child(1) div a.active.item > b");

        //Click on 'Search Skill' icon under Refine Results icon        
        IWebElement SubCategories => _driver.FindElementByCssSelector("div.ui.container div section div div.four.wide.column div.ui.small.icon.input.search-box > i");

        //Click on 'Programming&Tech' icon under Refine Results icon        
        IWebElement ProgrammingAndTech => _driver.FindElementByCssSelector("div.ui.container div section div div.four.wide.column div:nth-child(1) div > a:nth-child(7)");

        //Click on 'Online' Filter
        IWebElement OnlineFilter => _driver.FindElementByCssSelector("div.ui.container div section div div.four.wide.column div.ui.buttons > button:nth-child(1)");

        //Click on 'Onsite' Filter
        IWebElement OnsiteFilter => _driver.FindElementByCssSelector("div.ui.container div section div div.four.wide.column div.ui.buttons > button:nth-child(2)");

        //Click on 'ShowAll' Filter
        IWebElement ShowAllFilter => _driver.FindElementByCssSelector("div.ui.container div section div div.four.wide.column div.ui.buttons > button:nth-child(3)");

        #region Search Skills
        public void AllCategorySearchSkills()
        {
            #region Navigate to Search Skills icon
            //Click on Search Skills icon
            SearchSkill.Click();

            #endregion

            #region Click on All Categories
            //Click on Sent Requests
            AllCategories.WaitForElementClickable(_driver, 30);
            AllCategories.Click();
            //Thread.Sleep(500);
            //Base.test.Log(LogStatus.Info, "All Category Search successful");
            #endregion

        }
        #endregion

        #region Search Skills on Sub Categories 
        public void SubCategorySearchSkills()
        {
            #region Navigate to Search Skills icon
            //Click on Search Skills icon
            SearchSkill.Click();

            #endregion

            #region Click on Sub Categories
            //Click on Sub Categories
            ProgrammingAndTech.WaitForElementClickable(_driver, 30);
            ProgrammingAndTech.Click();

            #endregion

        }
        #endregion

        #region Filters
        //Search Skills under 'Online' Filter 
        public void OnlineSearchSkill()
        {
            #region Navigate to Search Skills icon
            //Click on Search Skills icon
            SearchSkill.Click();

            #endregion

            #region Click on Sub Categories
            //Click on Sub Categories
            OnlineFilter.WaitForElementClickable(_driver, 30);
            OnlineFilter.Click();

            #endregion

        }
        #endregion

        #region Filters
        //Search Skills under 'Onsite' Filter
        public void OnsiteSearchSkill()
        {
            #region Navigate to Search Skills icon
            //Click on Search Skills icon
            SearchSkill.Click();

            #endregion

            #region Click on Sub Categories
            //Click on Sub Categories
            OnsiteFilter.WaitForElementClickable(_driver, 30);
            OnsiteFilter.Click();

            #endregion

        }
        #endregion

        #region Filters
        //Search Skills under 'ShowAll' Filter
        public void ShowAllSearchSkill()
        {
            #region Navigate to Search Skills icon
            //Click on Search Skills icon
            SearchSkill.Click();

            #endregion

            #region Click on Sub Categories
            //Click on Sub Categories
            ShowAllFilter.WaitForElementClickable(_driver, 30);
            ShowAllFilter.Click();

            #endregion

        }
        #endregion
    }
}
