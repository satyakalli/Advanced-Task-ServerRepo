using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    internal class Profile
    {
        private RemoteWebDriver _driver;
        public Profile(RemoteWebDriver driver)
        {
            _driver = driver;

            PageFactory.InitElements(driver, this);

            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            Thread.Sleep(1000);
        }

        #region  Initialize Web Elements 
        //Click on Edit button
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/span/a/div/i")]
        //[FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        private IWebElement ProfileEdit { get; set; }

        //Click on Availability Time dropdown
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[2]/div")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div")]
                
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[2]/div/div[2]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour Edit button
        [FindsBy(How = How.XPath, Using = "/html/body/div[@class='ui']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement AvailabilityHourEditButton { get; set; }

        //Click on Availability Hour dropdown
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[3]/div")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[@class='ui']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select")]
        private IWebElement AvailabilityHours { get; set; }

        //Click on Earn Target Edit button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement EarnTargetEditButton { get; set; }

        //Click on salary
        // [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[4]/div")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select")]
        private IWebElement Salary { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

        //Click on Add new to add new Language
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[1]/input")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddLangText { get; set; }

        //Click on 'Choose Language Level' from 'Level' dropdown
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseLang { get; set; }

        //'Choose Language Level' from 'Level' dropdown
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseLangOpt { get; set; }

        //Add Language
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[3]/div/div[2]/div/div/div[3]/input[1]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddLang { get; set; }

        //Click on 'Skills' tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        private IWebElement SkillsTab { get; set; }

        //Click on 'AddNew' button to add new skill
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/table/thead/tr/th[3]/div")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
       // [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[1]/input")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input")]
        private IWebElement AddSkillText { get; set; }

        //Click on 'Choose Skill Level' from 'Level' dropdown
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //'Choose Skill Level' from 'Level' dropdown
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/span/input[1]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")]
        private IWebElement AddSkill { get; set; }

        //Click on 'Educaiton' tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")]
        private IWebElement EducaitonTab { get; set; }

        //Click on Add new to Educaiton
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/table/thead/tr/th[6]/div")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement AddNewEducation { get; set; }

        //Enter university in the text box
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[1]/input")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the country level option
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click the 'Title'
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose the 'Title' from Title dropdown
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[8]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
       // [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[2]/input")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        // [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement DegreeYear { get; set; }

        //Choose Year
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[2]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Click on 'Certifications' tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")]
        private IWebElement CertificationsTab { get; set; }

        //Add new Certificate
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/table/thead/tr/th[4]/div")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement AddNewCerti { get; set; }

        //Enter Certification Name
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[1]/div/input")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[1]/input")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")]
        private IWebElement CertiFrom { get; set; }

        //Year
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

        //Choose Opt from Year
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select/option[5]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]")]
        private IWebElement CertiYearOpt { get; set; }

        //Add Ceritification
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[3]/input[1]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")]
        private IWebElement AddCerti { get; set; }

        //Click on 'Edit/Pencil' icon Description
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        //[FindsBy(How = How.XPath, Using = "div section:nth-child(3) div div div div.eight.wide.column div div div h3 span > i")]
        private IWebElement EditDescription { get; set; }

        //Add Desctiption
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        private IWebElement Save { get; set; }

        //To change 'Password'
        ////Click on account profile name
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span")]
        //private IWebElement AccountProfile { get; set; }

        //Click on Change Password
        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]")]
        //private IWebElement ChangePassword { get; set; }

        //CurrentPassword
        //[FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[2]/form/div[1]/input")]
        //private IWebElement CurrentPassword { get; set; }

        #endregion

        internal void EditProfile()
        {

            EditAvailability();
                        
            EditHours();

            EditEarnTarget();

            AddLanguageRecord();

            AddSkillRecord();

            AddEducationRecord();

            AddCertificationRecord();

            AddDescription();                       
        }
    
        internal void EditAvailability()
        {
            editAvailabilityClickEditIcon();

            modifyAvailability();

            validateAvailability();
        }

        internal void editAvailabilityClickEditIcon()
        {
            //Click on Edit button
            ProfileEdit.Click();
            Thread.Sleep(5000);
        }

        internal void modifyAvailability()
        {
            #region Availability Time option
            Thread.Sleep(1500);
            Actions action = new Actions(_driver);
            action.MoveToElement(AvailabilityTime).Build().Perform();
            Thread.Sleep(1000);
            IList<IWebElement> AvailableTime = AvailabilityTimeOpt.FindElements(By.TagName("option"));
            int count = AvailableTime.Count;
            for (int i = 0; i < count; i++)
            {
                if (AvailableTime[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"))
                {
                    AvailableTime[i].Click();
                    Base.test.Log(LogStatus.Info, "Select the available time");

                }
            }
            Thread.Sleep(1000);
            #endregion
        }

        internal void validateAvailability()
        {
            #region Check whether Availability edited sucessfully 
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);

            string AvailabilitySucess = _driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show")).Text;

            if (AvailabilitySucess == "Availability updated")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Availability Update Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Availability Update Unsuccessful");
            }
            // Screenshot
            SaveScreenShotClass.SaveScreenshot(_driver, "Edit_Availabilty");
            #endregion
        }

        internal void EditHours()
        {
            editHoursClickEditIcon();

            modifyHours();

            validateHours();
        }

        internal void editHoursClickEditIcon()
        {
            #region Availability Hours
            AvailabilityHourEditButton.Click();
            #endregion
        }

        internal void modifyHours()
        {
            #region Availability Hours option
            AvailabilityHours.Click();
            AvailabilityHours.SendKeys(Keys.ArrowDown);
            AvailabilityHours.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            #endregion
        }

        internal void validateHours()
        {
            #region Check whether Hours edited sucessfully 
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);

            string HoursSucess = _driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show")).Text;

            if (HoursSucess == "Availability updated")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Hours Update Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Hours Update Unsuccessful");
            }

            // Screenshot
            SaveScreenShotClass.SaveScreenshot(_driver, "Edit_Hours");
            #endregion
        }

        internal void EditEarnTarget()
        {
            editEarnTargetClickEditIcon();

            modifyEarnTarget();

            validateEarnTarget();                        
        }

        internal void editEarnTargetClickEditIcon()
        {
            #region Earn Target Edit Button
            EarnTargetEditButton.Click();
            #endregion
        }

        internal void modifyEarnTarget()
        {
            #region Salary 
            Salary.Click();
            //Choose the option from salary dropdown
            Salary.SendKeys(Keys.ArrowDown);
            Salary.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            #endregion
        }

        internal void validateEarnTarget()
        {
            #region Check whether EarnTarget edited sucessfully 
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);

            string EarnTargetSucess = _driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show")).Text;

            if (EarnTargetSucess == "Availability updated")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "EarnTarget Update Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "EarnTarget Update Unsuccessful");
            }

            // Screenshot
            SaveScreenShotClass.SaveScreenshot(_driver, "Edit_EarnTarget");
            #endregion
        }

        internal void AddLanguageRecord()
        {
            addnewLanguageButtonClick();

            addLanguageAndLevel();

            addLanguageClickAddButton();

            validateLanguage();            
        }
       
        internal void addnewLanguageButtonClick()
        {
            #region 
            //Click on Add New Language button
            AddNewLangBtn.Click();
            #endregion
        }

        internal void addLanguageAndLevel()
        {
            #region Enter the Language
            AddLangText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));
            //Choose Language
            ChooseLang.Click();
            Thread.Sleep(1000);
            ChooseLangOpt.Click();
            #endregion
        }

        internal void addLanguageClickAddButton()
        {
            #region
            AddLang.Click();
            Thread.Sleep(1000);
            Base.test.Log(LogStatus.Info, "Added Language successfully");
            #endregion
        }

        internal void validateLanguage()
        {
            #region Check whether new 'Language' record created successfully
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);

            String LanguagesSuccess = _driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show")).Text;

            if (LanguagesSuccess == "English has been added to your languages")
            //if (LanguagesSuccess.Contains("has been added to your languages"))
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "English has been added Successfully");

            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "English hasn't been added successfully");
            }
            // Screenshot
            SaveScreenShotClass.SaveScreenshot(_driver, "Add_Language");
            #endregion
        }

        internal void AddSkillRecord()
        {
            addnewSkillButtonClick();

            addSkillAndLevel();

            addSkillClickAddButton();

            validateSkill();
        }

        internal void addnewSkillButtonClick()
        {
            #region Click on 'Skills' tab
            SkillsTab.Click();
            //Click on 'Add New' Skill Button
            AddNewSkillBtn.Click();
            Thread.Sleep(1000);
            #endregion
        }

        internal void addSkillAndLevel()
        {
            # region Enter the skill 
            AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));
            //Click the skill dropdown
            ChooseSkill.Click();
            Thread.Sleep(1000);
            ChooseSkilllevel.Click();
            #endregion
        }

        internal void addSkillClickAddButton()
        {
            # region 
            AddSkill.Click();
            Thread.Sleep(1000);
            Base.test.Log(LogStatus.Info, "Added Skills successfully");
            #endregion
        }
        internal void validateSkill()
        {
            #region Check whether new 'Skill' record created successfully
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);

            String SkillSuccess = _driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show")).Text;

            if (SkillSuccess == "Automation Testing has been added to your skills")
            //if (SkillSuccess.Contains("has been added to your skills"))
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skill has been added Successfully");

            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Skill hasn't been added successfully");
            }
            // Screenshot
            SaveScreenShotClass.SaveScreenshot(_driver, "Add_Skill");
            #endregion
        }

        internal void AddEducationRecord()
        {
            addnewEducationButtonClick();

            addEducationAndLevel();

            addEducationClickAddButton();

            validateEducation();
        }

        internal void addnewEducationButtonClick()
        {
            #region 
            //Click on 'Education' tab
            EducaitonTab.Click();
            Thread.Sleep(5000);
            #endregion
        }

        internal void addEducationAndLevel()
        {
            #region
            //Add Education
            AddNewEducation.Click();

            //Enter the University
            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

            //Enter Degree
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

            //Choose Country
            ChooseCountry.Click();
            Thread.Sleep(1000);
            //Choose Country Level
            ChooseCountryOpt.Click();

            //Choose Title
            ChooseTitle.Click();
            Thread.Sleep(1000);
            ChooseTitleOpt.Click();

            //Year of Graduation
            DegreeYear.Click();
            Thread.Sleep(500);
            DegreeYearOpt.Click();
            #endregion
        }

        internal void addEducationClickAddButton()
        {
            # region
            AddEdu.Click();
            Thread.Sleep(500);
            Base.test.Log(LogStatus.Info, "Added Education successfully");
            #endregion
        }
        internal void validateEducation()
        {

            #region Check whether new 'Education' record created successfully
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);

            String EducationSuccess = _driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show")).Text;

            //if (EducationSuccess == "has been added")
            if (EducationSuccess.Contains("has been added"))
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Education has been added");

            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Education hasn't been added");
            }
            // Screenshot
            SaveScreenShotClass.SaveScreenshot(_driver, "Add_Education");
            #endregion
        }
        internal void AddCertificationRecord()
        {
            addnewCertificationButtonClick();

            addCertificationDetails();

            addCertificationAddClickButton();

            validateCertifications();
        }

        internal void addnewCertificationButtonClick()
        {
            #region 
            //Click on 'Certifications' tab
            CertificationsTab.Click();
            Thread.Sleep(5000);
            //Add new Certificate            
            AddNewCerti.Click();
            #endregion
        }

        internal void addCertificationDetails()
        {
            #region 
            //Enter Certificate Name
            EnterCerti.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

            //Enter Certified from
            CertiFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

            //Enter the Year
            CertiYear.Click();
            Thread.Sleep(500);
            CertiYearOpt.Click();
            #endregion
        }

        internal void addCertificationAddClickButton()
        {
            #region
            AddCerti.Click();
            Thread.Sleep(500);
            Base.test.Log(LogStatus.Info, "Adding Certificate");
            #endregion
        }

        internal void validateCertifications()
        {
            #region Check whether new 'Certification' record created successfully
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);

            String CertificateSuccess = _driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show")).Text;

            //if (CertificateSuccess == "has been added")
            if (CertificateSuccess.Contains("has been added"))
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Certification has been added");

            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Certification hasn't been added");
            }
            // Screenshot
            SaveScreenShotClass.SaveScreenshot(_driver, "Add_Certifications");
            #endregion
        }

        internal void AddDescription()
        {
            editDescription();

            enterTextToDescription();

            addedDescriptionToSave();

            validateDescription();
        }

        internal void editDescription()
        {
            #region Click on 'Edit/Pencil' icon Description
            EditDescription.Click();
            #endregion
        }

        internal void enterTextToDescription()
        {
            #region
            Thread.Sleep(5000);
            Description.Clear();
            //Add Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            #endregion
        }

        internal void addedDescriptionToSave()
        {
            #region             
            Save.Click();
            Thread.Sleep(500);
            Base.test.Log(LogStatus.Info, "Save Description");
            #endregion
        }

        internal void validateDescription()
        {
            #region Check whether new 'Description' created successfully
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show"), 10);

            String DescriptionSuccess = _driver.FindElement(By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show")).Text;

            //if (DescriptionSuccess == "has been added to your Description")
            if (DescriptionSuccess == "Description has been saved successfully")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Description has been added successfully");

            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Description hasn't been added successfully");
            }
            // Screenshot
            SaveScreenShotClass.SaveScreenshot(_driver, "Add_Description");
            #endregion
        }
    }
}