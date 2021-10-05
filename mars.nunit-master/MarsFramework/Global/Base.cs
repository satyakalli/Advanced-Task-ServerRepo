﻿using MarsFramework.Config;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;
using System.IO;
using OpenQA.Selenium;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using BoDi;

namespace MarsFramework.Global
{
    //Use only when running tests with NUnit
    //public enum BrowserType
    //{
    //    Firefox,
    //    Chrome
    //}
    //[TestFixture] //Use only when running tests with NUnit

    [Binding] //Use only when running tests with SpecFlow
    public class Base
    {
        //private BrowserType _BrowserType; //Use only when running tests with NUnit
        public static RemoteWebDriver _driver;

        //Use only when running tests with NUnit
        //public Base(BrowserType browser)
        //{
        //    this._BrowserType = browser;
        //}

        #region To access Path from resource file / Dynamic paths

        // public static int Browser = Int32.Parse(MarsResource.Browser);

        // Excel path
        public static String ExcelPath = Directory.GetCurrentDirectory() + @"..\..\..\..\..\..\..\Users\satya\source\repos\Advanced-Task\mars.nunit-master\MarsFramework\ExcelData\TestData.xlsx";

        // Path to Save Screenshots
        public static String ScreenshotPath = Directory.GetCurrentDirectory() + @"..\..\..\..\..\..\..\..\..\Users\satya\source\repos\Advanced-Task\mars.nunit-master\MarsFramework\TestReports\Screenshots\";

        // Report path
        public static String ReportPath = Directory.GetCurrentDirectory() + @"..\..\..\..\..\..\..\Users\satya\source\repos\Advanced-Task\mars.nunit-master\MarsFramework\TestReports\MarsReports.html";

        // Report XML path
        public static String ReportXMLPath = Directory.GetCurrentDirectory() + @"..\..\..\Users\satya\source\repos\Advanced-Task\mars.nunit-master\MarsFramework\Config\XMLFile.xml";

        #endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;

        #endregion

        //#region setup and tear down
        //[SetUp]
        //public void InititalizeTest()
        //{

        //    // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/

        //    ChooseBrowser(_BrowserType);


        //    void ChooseBrowser(BrowserType browserType)
        //    {
        //        if (browserType == BrowserType.Firefox)
        //        {
        //            _driver = new FirefoxDriver();
        //        }
        //        else if (browserType == BrowserType.Chrome)
        //        {
        //            _driver = new ChromeDriver();
        //        }

        //        _driver.Manage().Window.Maximize();

        //    }

        //    #region Initialise Reports

        //    extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
        //    extent.LoadConfig(ReportXMLPath);

        //    #endregion

        //    if (MarsResource.IsLogin == "true")
        //    {
        //        SignIn loginobj = new SignIn(_driver);
        //        loginobj.LoginSteps();
        //    }
        //    else
        //    {
        //        SignUp obj = new SignUp(_driver);
        //        obj.register();
        //    }

        //}


        //[TearDown]
        //public void TearDown()
        //{

        //    if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
        //    {
        //        // Screenshot
        //        String img = SaveScreenShotClass.SaveScreenshot(_driver, "Report");
        //        //AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
        //        test.Log(LogStatus.Error, "Image example: " + img);
        //    }

        //    // end test. (Reports)
        //    extent.EndTest(test);
        //    // calling Flush writes everything to the log file (Reports)
        //    extent.Flush();
        //    // Close the driver :)            
        //    _driver.Close();
        //}
        //#endregion


        //SpecFlow
        #region BeforeScenario and AfterScenario
        [BeforeScenario]
        public void SetUpSpecFlow()
        {
            // advisable to read this documentation before proceeding http://extentreports.relevantcodes.com/net/

            //Use only when running tests with NUnit
            //ChooseBrowser(_BrowserType);

            //Use only when running tests with NUnit
            //void ChooseBrowser(BrowserType browserType)
            //{
            //    if (browserType == BrowserType.Firefox)
            //    {
            //        _driver = new FirefoxDriver();
            //    }
            //    else if (browserType == BrowserType.Chrome)
            //    {
            //        _driver = new ChromeDriver();
            //    }

            //    _driver.Manage().Window.Maximize();

            //}

            //Use only when running tests with SpecFlow
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();

            #region Initialise Reports

            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(ReportXMLPath);

            #endregion

            if (MarsResource.IsLogin == "true")
            {
                SignIn loginobj = new SignIn(_driver);
                loginobj.LoginSteps();
            }
            else
            {
                SignUp obj = new SignUp(_driver);
                obj.register();
            }

        }


        [AfterScenario]
        public void TearDownSpecFlow()
        {

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                // Screenshot
                String img = SaveScreenShotClass.SaveScreenshot(_driver, "Report");
                //AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
                test.Log(LogStatus.Error, "Image example: " + img);
            }

            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            _driver.Close();
        }
        #endregion

    }
}