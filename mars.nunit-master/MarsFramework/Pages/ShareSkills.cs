using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.IO;
using System.Threading;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    internal class ShareSkills
    {

        private RemoteWebDriver _driver;
        private static String newRecordTitle;
        private static String editRecordTitle;

        public ShareSkills(RemoteWebDriver driver) => _driver = driver;

        //PageFactory.InitElements(driver, this);
               
        // ShareSkills button
        IWebElement ShareSkill => _driver.FindElementByCssSelector("div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button");

        // ManageListings button        
        IWebElement ManageListings => _driver.FindElementByCssSelector("div div section.nav-secondary div > a:nth-child(3)");

        //Edit 
        IWebElement Edit => _driver.FindElementByCssSelector("div div:nth-child(3) div:nth-child(2) div:nth-child(1) table tbody tr:nth-child(1) td:nth-child(8) div button:nth-child(2) > i");

        //Delete
        IWebElement Delete => _driver.FindElementByCssSelector("div div:nth-child(3) div:nth-child(2) div:nth-child(1) table tbody tr:nth-child(1) td:nth-child(8) div button:nth-child(3) i");

        //Cofirm delete
        IWebElement CofirmDelete => _driver.FindElementByCssSelector("body div.ui.page.modals.dimmer.transition.visible.active div div.actions > button.ui.icon.positive.right.labeled.button");

        // Title
        IWebElement Title => _driver.FindElementByName("title");

        // Description
        IWebElement Description => _driver.FindElementByName("description");

        // Select Category
        IWebElement Category => _driver.FindElementByName("categoryId");

        // Select Graphics & Design
        IWebElement GraphicsDesign => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)");

        //Select SubCategory - Logo Design
        IWebElement SubCategory => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) > select.ui.fluid.dropdown");

        //Select SubCategory - Logo Design
        IWebElement LogoDesign => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)");

        //Select Tag Names
        IWebElement Tag => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField");

        //Select Service Type -Hourly Basis
        IWebElement ServiceTypeHourly => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        //Select Service Type -One-off
        IWebElement ServiceTypeOnOff => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");
        //Select Location Type - Onsite

        //Select Location Type - Onsite
        IWebElement LocationTypeOnsite => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        //Select Location Type - Onsite
        IWebElement LocationTypeOnline => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)");

        //Avilable Days -Start Date
        IWebElement StartDate => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)");

        //Avilable Days -End Date
        IWebElement EndDate => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)");

        //Skill Trade - Skill Exchange
        IWebElement SkillExchange => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        // Skill Exchange - Required Skills
        IWebElement RequiredSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField");

        //Skill Trade - Credit
        IWebElement Credit => _driver.FindElementByCssSelector("div div.ui.container div form div:nth-child(8) div.twelve.wide.column div div:nth-child(2) div > input[type=radio]");


        //Credit - Enter Amount
        IWebElement CreditAmount => _driver.FindElementByCssSelector("div div.ui.container div form div:nth-child(8) div.ten.wide.column div div > input[type=text]");

        // Status Active 
        IWebElement StatusActive => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)");

        // Status Hidden 
        IWebElement StatusHidden => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)");

        // Work Sample 
        IWebElement WorkSample => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(9) div.row div.twelve.wide.column div:nth-child(1) label.worksamples-file:nth-child(1) div.ui.grid span:nth-child(1) > i.huge.plus.circle.icon.padding-25");

        // Save Share Skills
        IWebElement SaveShareSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)");

        // Cancel Share Skills
        IWebElement CancelShareSkills => _driver.FindElementByCssSelector("div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)");

        // Click on Manage Requests
        IWebElement ManageRequests => _driver.FindElementByCssSelector("div div section.nav-secondary div > div.ui.dropdown.link.item");

        //Click on Received Requests
        IWebElement ReceivedRequests => _driver.FindElementByCssSelector("div section.nav-secondary div div.ui.dropdown.link.item div > a:nth-child(1)");

        //Click on Sent Requests
        IWebElement SentRequests => _driver.FindElementByCssSelector("div section.nav-secondary div div.ui.dropdown.link.item div > a:nth-child(2)");

        #region Initialize Elements - Pagefactory Implementation
        /*  [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[1]/div/a[1]")]
          public IWebElement Dashboard { get; set; }

          [FindsBy(How = How.ClassName, Using = "item active")]
          public IWebElement Skills { get; set; }*/


        //[FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/section[1]/div/div[2]/a")]
        /*   [FindsBy(How = How.CssSelector, Using = "div.ui:nth-child(1) div:nth-child(1) section.nav-secondary:nth-child(2) div.ui.eight.item.menu div.right.item:nth-child(5) > a.ui.basic.green.button")]
           public IWebElement ShareSkill { get; set; }


           // Title
           [FindsBy(How = How.Name, Using = "title")]
           public IWebElement Title { get; set; }


           // Description

           [FindsBy(How = How.Name, Using = "description")]
           public IWebElement Description { get; set; }

           // Select Category

           [FindsBy(How = How.Name, Using = "categoryId")]
           public IWebElement Category { get; set; }

           // Select Graphics & Design

           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
           public IWebElement GraphicsDesign { get; set; }


           //Select SubCategory - Logo Design
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) > select.ui.fluid.dropdown")]
           public IWebElement SubCategory { get; set; }

           //Select SubCategory - Logo Design
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(2) div.fields:nth-child(1) select.ui.fluid.dropdown > option:nth-child(2)")]
           public IWebElement LogoDesign { get; set; }


           //Select Tag Names
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(4) div.twelve.wide.column div.form-wrapper.field div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
           public IWebElement Tag { get; set; }

           //Select Service Type -Hourly Basis
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement ServiceTypeHourly { get; set; }

           //Select Service Type -One-off
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(5) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement ServiceTypeOnOff { get; set; }

           //Select Location Type - Onsite
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement LocationTypeOnsite { get; set; }

           //Select Location Type - Onsite
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(6) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > input:nth-child(1)")]
           public IWebElement LocationTypeOnline { get; set; }

           //Avilable Days -Start Date
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(2) > input:nth-child(1)")]
           public IWebElement StartDate { get; set; }

           //Avilable Days -End Date
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(7) div.twelve.wide.column div.form-wrapper div.fields:nth-child(1) div.five.wide.field:nth-child(4) > input:nth-child(1)")]
           public IWebElement EndDate { get; set; }

           //Skill Trade - Skill Exchange
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement SkillExchange { get; set; }

           // Skill Exchange - Required Skills
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(4) div.field div.form-wrapper div.ReactTags__tags div.ReactTags__selected div.ReactTags__tagInput > input.ReactTags__tagInputField")]
           public IWebElement RequiredSkills { get; set; }

           //Skill Trade - Credit
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.twelve.wide.column:nth-child(2) div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement Credit { get; set; }


           //Credit - Enter Amount
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(8) div.ten.wide.column:nth-child(4) div:nth-child(1) div.ui.right.labeled.input > input:nth-child(2)")]
           public IWebElement CreditAmount { get; set; }

           // Status Active 
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(1) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement StatusActive { get; set; }

           // Status Hidden 
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(10) div.twelve.wide.column div.inline.fields div.field:nth-child(2) div.ui.radio.checkbox > label:nth-child(2)")]
           public IWebElement StatusHidden { get; set; }

           // Work Sample 
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(9) div.row div.twelve.wide.column div:nth-child(1) label.worksamples-file:nth-child(1) div.ui.grid span:nth-child(1) > i.huge.plus.circle.icon.padding-25")]
           public IWebElement WorkSample { get; set; }

           // Save Share Skills
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
           public IWebElement SaveShareSkills { get; set; }

           // Cancel Share Skills
           [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.ui.vertically.padded.right.aligned.grid:nth-child(11) div.sixteen.wide.column > input.ui.teal.button:nth-child(1)")]
           public IWebElement CancelShareSkills { get; set; }*/

        #endregion


        #region Add new Skill
        public void AddNewSkill()
        {
            newShareSkillButtonClick();

            enterNewShareSkillDetails();

            saveNewShareSkill();

            validateNewShareSkill();
        }
        #endregion

        internal void newShareSkillButtonClick()
        {
            #region Navigate to Share Skills Page
            // Click on Share Skills Page
            ShareSkill.WaitForElementClickable(_driver, 60);
            ShareSkill.Click();
            #endregion
        }

        internal void enterNewShareSkillDetails()
        {
            #region Populate the excel data            
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkills"); 
            //Enter Title 
            Title.WaitForElementClickable(_driver, 60);
            //Enter the data in Title textbox
            newRecordTitle = GlobalDefinitions.ExcelLib.ReadData(2, "title");
            Title.SendKeys(newRecordTitle);
            #endregion

            #region Enter Description
            //Enter the data in Description textbox
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EnterDescription"));

            #endregion

            #region Category Drop Down
            // Click on Category Dropdown
            Category.Click();

            // Select Category from Category Drop Down
            var SelectElement = new SelectElement(Category);
            SelectElement.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "category")));

            // Click on Sub-Category Dropdown
            SubCategory.Click();

            //Select Sub-Category from the Drop Down
            var SelectElement1 = new SelectElement(SubCategory);
            SelectElement1.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "subcategory")));
            #endregion

            #region Tags
            // Eneter Tag
            Tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "TagName"));
            Tag.SendKeys(Keys.Enter);

            #endregion

            #region Service Type Selection

            // Service Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "Hourly basis service")
            {
                ServiceTypeHourly.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "One-off service")
            {
                ServiceTypeOnOff.Click();
            }
            #endregion

            #region Select Location Type
            // Location Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "On-site")
            {
                LocationTypeOnsite.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "Online")
            {
                LocationTypeOnline.Click();
            }
            #endregion

            #region Select Available Dates from Calendar
            // Select Start Date
            StartDate.Click();
            // Select End Date
            EndDate.Click();
            #endregion

            #region Select Skill Trade
            // Select Skill Trade

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Skill-exchange")
            {

                RequiredSkills.Click();
                RequiredSkills.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ExchangeSkill"));
                RequiredSkills.SendKeys(Keys.Enter);

            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Credit")
            {

                CreditAmount.Click();
                CreditAmount.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "AmountInExchange"));
                CreditAmount.SendKeys(Keys.Enter);
            }
            #endregion

            #region Select User Status
            // Select User Status

            if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Active")
            {
                StatusActive.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Hidden")
            {
                StatusHidden.Click();
            }
            #endregion

            //#region Add Work Sample

            //Work Sample upload button path
            //IWebElement upload = _driver.FindElement(By.XPath("//*[@id='selectFile']"));

            //Uploading File path
            //var GetCurrentDirectory = Directory.GetCurrentDirectory();
            //String path = @"C:\Users\satya\source\repos\Advanced-Task\mars.nunit-master\MarsFramework\Upload Files\Samplework.txt";
            //upload.SendKeys(path);
            //#endregion
        }

        internal void saveNewShareSkill()
        {
            #region Save / Cancel Skill
            // Save or Cancel New Skill

            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Save")
            {
                SaveShareSkills.Click();
            }
            else if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Cancel")
            {
                CancelShareSkills.Click();
            }
            Thread.Sleep(1000);
            Base.test.Log(LogStatus.Info, "Added ShareSkill successfully");
            #endregion
        }

        internal void validateNewShareSkill()
        {
            #region Check whether New  skill created sucessfully 
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("div:nth-child(3) div:nth-child(2) div:nth-child(1) table tbody tr:nth-child(1) > td:nth-child(3)"), 10);

            string firstRecordTitleInManageListings = _driver.FindElement(By.CssSelector("div:nth-child(3) div:nth-child(2) div:nth-child(1) table tbody tr:nth-child(1) > td:nth-child(3)")).Text;

            if (firstRecordTitleInManageListings == newRecordTitle)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Created Skill Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Created Skill Unsuccessful");
            }
            // Screenshot
            SaveScreenShotClass.SaveScreenshot(_driver, "Add_ShareSkill");
            #endregion
        }

        #region Edit Skill
        public void EditShareSkill()
        {
            navigateToManageListingsPage();

            editShareSkill();

            modifyShareSkillDetails();

            saveModifiedShareSkill();

            validateModifiedShareSkill();
        }
        #endregion

        internal void navigateToManageListingsPage()
        {
            #region Navigate to Manage Listings Page
            //Populate the excel data            
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
           // Click on Manage Listings Page
            ManageListings.WaitForElementClickable(_driver, 60);
            ManageListings.Click();
            #endregion
        }

        internal void editShareSkill()
        {
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("div div:nth-child(3) div:nth-child(2) div:nth-child(1) table tbody tr:nth-child(1) td:nth-child(8) div button:nth-child(2) > i"), 10);

            //Click on 'Pencil' icon to Edit
            Edit.WaitForElementClickable(_driver, 60);
            Edit.Click();
        }

        internal void modifyShareSkillDetails()
        {             
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.Name("title"), 10);

            #region Enter Title 
            Title.WaitForElementClickable(_driver, 60);
            //Clear the data in the Title text box
            Title.Clear();
            //Edit the data in Title textbox
            editRecordTitle = GlobalDefinitions.ExcelLib.ReadData(2, "title");
            Title.SendKeys(editRecordTitle);
            #endregion

            #region Enter Description
            //Clear the data in the Description textbox
            Description.Clear();
            //Enter the data in Description textbox
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EnterDescription"));
            #endregion

            #region Category Drop Down
            // Click on Category Dropdown
            Category.Click();


            // Select Category from Category Drop Down
            var SelectElement = new SelectElement(Category);
            SelectElement.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "category")));

            // Click on Sub-Category Dropdown
            SubCategory.Click();

            //Select Sub-Category from the Drop Down
            var SelectElement1 = new SelectElement(SubCategory);
            SelectElement1.SelectByText((GlobalDefinitions.ExcelLib.ReadData(2, "subcategory")));
            #endregion

            #region Tags
            // Eneter Tag
            //Clear the data in the Tag text box
            Tag.Clear();
            //Enter the data in Tag textbox
            Tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "TagName"));
            Tag.SendKeys(Keys.Enter);
            #endregion

            #region Service Type Selection

            // Service Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "Hourly basis service")
            {
                ServiceTypeHourly.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "One-off service")
            {
                ServiceTypeOnOff.Click();
            }
            #endregion

            #region Select Location Type
            // Location Type Selection

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "On-site")
            {
                LocationTypeOnsite.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectLocationType") == "Online")
            {
                LocationTypeOnline.Click();
            }
            #endregion

            #region Select Available Dates from Calendar
            // Select Start Date            
            //StartDate.WaitForElementClickable(_driver, 10);
            StartDate.Clear();
            //Date for exsisting 
            string newStartDateForExistingRecord = ExcelLib.ReadData(2, "Startdate");
            StartDate.SendKeys(newStartDateForExistingRecord);
            //StartDate.SendKeys("27/08/2021");
            // Select End Date
            EndDate.Click();
            #endregion


            #region Select Skill Trade
            // Select Skill Trade

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Skill-exchange")
            {
                RequiredSkills.Click();
                RequiredSkills.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "ExchangeSkill"));
                RequiredSkills.SendKeys(Keys.Enter);
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "SelectSkillTrade") == "Credit")
            {
                Credit.Click();
                CreditAmount.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "AmountInExchange"));
                CreditAmount.SendKeys(Keys.Enter);
            }
            #endregion

            #region Select User Status
            // Select User Status
            if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Active")
            {
                StatusActive.Click();
            }
            else if (GlobalDefinitions.ExcelLib.ReadData(2, "UserStatus") == "Hidden")
            {
                StatusHidden.Click();
            }
            #endregion

            //#region Add Work Sample
            //Work Sample upload button path
            //IWebElement upload = _driver.FindElement(By.XPath("//*[@id='selectFile']"));

            // Uploading File path
            //var GetCurrentDirectory = Directory.GetCurrentDirectory();
            //String path = @"C:\Users\satya\source\repos\Advanced-Task\mars.nunit-master\MarsFramework\Upload Files\Samplework.txt";
            //upload.SendKeys(path);
            //#endregion
        }
       internal void saveModifiedShareSkill()
        {
            #region Save / Cancel Skill
            // Save or Cancel New Skill
            if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Save")
            {
                SaveShareSkills.Click();
            }
            else if (Global.GlobalDefinitions.ExcelLib.ReadData(2, "SaveOrCancel") == "Cancel")
            {
                CancelShareSkills.Click();
            }
            #endregion
        }
       internal void validateModifiedShareSkill()
       {
            #region Check whether Edited skill is sucessfull
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("div:nth-child(3) div:nth-child(2) div:nth-child(1) table tbody tr:nth-child(1) > td:nth-child(3)"), 10);
                                                                             
            string editExsistingRecordTitleInManageListing = _driver.FindElement(By.CssSelector("div:nth-child(3) div:nth-child(2) div:nth-child(1) table tbody tr:nth-child(1) > td:nth-child(3)")).Text;

            if (editExsistingRecordTitleInManageListing == editRecordTitle)
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Service Listing Update Successful");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Service Skill Updated Unsuccessful");
            }
            // Screenshot
            Thread.Sleep(1000);
            SaveScreenShotClass.SaveScreenshot(_driver, "Edit_ShareSkill");
            #endregion
        }

        #region Delete Skill
        public void DeleteExsistingSkill()
        {
            navigateToManageListingsPageToDeleteShareSkill();
                       
            confirmDeleteShareSkill();

            validateDeleteShareSkill();                                   
        }
       

        internal void navigateToManageListingsPageToDeleteShareSkill()
        {
            #region Navigate to Manage Listings Page
            // Click on Manage Listings Page
            ManageListings.WaitForElementClickable(_driver, 60);
            ManageListings.Click();
            #endregion
        }

        internal void confirmDeleteShareSkill()
        {
            #region 
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("div div:nth-child(3) div:nth-child(2) div:nth-child(1) table tbody tr:nth-child(1) td:nth-child(8) div button:nth-child(3) > i"), 10);
            //Click on 'Cross' icon to delete
            Delete.WaitForElementClickable(_driver, 60);
            Delete.Click();
            CofirmDelete.WaitForElementClickable(_driver, 60);
            CofirmDelete.Click();
            #endregion
        }

        internal void validateDeleteShareSkill()
        {
            #region Check whether Delete skill is sucessful 
            //Wait
            Global.GlobalDefinitions.WaitForElement(_driver, By.CssSelector("div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show > div"), 10);

            string DeleteShareSkill = _driver.FindElement(By.CssSelector("div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show > div")).Text;

            //if (DeleteShareSkill == "Testing has been deleted")
            if (DeleteShareSkill.Contains("has been deleted"))
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record deleted successfully");
            }
            else
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record was not deleted");
            }
            Thread.Sleep(1000);
            SaveScreenShotClass.SaveScreenshot(_driver, "Delete_ShareSkill");
            #endregion
        }

        #region Manage Received Requests
        public void RequestsReceived()
        {
            #region Navigate to Manage Request Page
            //Click on Manage Requests Page
            ManageRequests.Click();

            #endregion
            ReceivedRequests.WaitForElementClickable(_driver, 30);
            //Click on Received Requests
            ReceivedRequests.Click();           
        }
        #endregion

        #region Manage Sent Requests
        public void RequestsSent()
        {
            #region Navigate to Manage Request Page
           //Click on Manage Requests Page
            ManageRequests.Click();

            #endregion

            #region Click on Sent Request Page
            //Click on Sent Requests
            SentRequests.WaitForElementClickable(_driver, 30);
            SentRequests.Click();

            #endregion

        }
        #endregion
    }
}
#endregion