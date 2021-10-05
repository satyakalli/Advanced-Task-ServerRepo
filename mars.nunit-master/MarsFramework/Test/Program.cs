using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    [TestFixture(BrowserType.Firefox)]
    [TestFixture(BrowserType.Chrome)]
    [Parallelizable(ParallelScope.Fixtures)]
    [Category("sprint1")]
    public class Program : Base
    {
        public Program(BrowserType browser) : base(browser)
        {
        }

        [Test]
        public void join()
        {
            //create extent report
            test = extent.StartTest("signup");

            //join/register details
            SignUp obj = new SignUp(_driver);
            obj.register();
        }

        [Test]
        public void login()
        {
            //create extent report
            test = extent.StartTest("sign in");

            //join/register details
            SignIn obj = new SignIn(_driver);
            obj.LoginSteps();
        }

        [Test]
        public void editprofiledetails()
        {
            //create extent report
            test = extent.StartTest("profile");

            //edit profile details
            Profile obj = new Profile(_driver);
            obj.EditProfile();
        }

        [Test]
        public void profile_editavailability()
        {
            //create extent report
            test = extent.StartTest("edit availability profile");

            //edit availability and hour details
            Profile obj = new Profile(_driver);
            obj.EditAvailability();
        }

        [Test]
        public void profile_edithours()
        {
            //create extent report
            test = extent.StartTest("edit hours profile");

            //edit availability and hour details
            Profile obj = new Profile(_driver);
            obj.EditHours();
        }

        [Test]
        public void profile_editearntarget()
        {
            //create extent report
            test = extent.StartTest("edit earntarget profile");

            //edit earntarget on the profile page
            Profile obj = new Profile(_driver);
            obj.EditEarnTarget();
        }

        [Test]
        public void profile_addlanguage()
        {
            //create extent report
            test = extent.StartTest("add language on the profile");

            //add language details
            Profile obj = new Profile(_driver);
            obj.AddLanguageRecord();
        }

        [Test]
        public void profile_addskill()
        {
            //create extent report
            test = extent.StartTest("add skill on the profile");

            //add skill details
            Profile obj = new Profile(_driver);
            obj.AddSkillRecord();
        }

        [Test]
        public void profile_addeducation()
        {
            //create extent report
            test = extent.StartTest("add education on the profile");

            //add skill details
            Profile obj = new Profile(_driver);
            obj.AddEducationRecord();
        }

        [Test]
        public void profile_addcertification()
        {
            //create extent report
            test = extent.StartTest("add certification on the profile");

            //add skill details
            Profile obj = new Profile(_driver);
            obj.AddCertificationRecord();
        }

        [Test]
        public void profile_adddescription()
        {
            //create extent report
            test = extent.StartTest("add description on the profile");

            //add skill details
            Profile obj = new Profile(_driver);
            obj.AddDescription();
        }

        [Test]
        public void createnewshareskill()
        {
            //create extent report
            test = extent.StartTest("share skills");

            // create share skills      
            ShareSkills obj = new ShareSkills(_driver);
            obj.AddNewSkill();
        }

        [Test]
        public void editskillfrommanagelistings()
        {
            //create extent report
            test = extent.StartTest("manage listings");

            // create share skills      
            ShareSkills obj = new ShareSkills(_driver);
            obj.EditShareSkill();
        }

        [Test]
        public void deleteskillfrommanagelistings()
        {
            //create extent report
            test = extent.StartTest("manage listings");

            // delete share skill      
            ShareSkills obj = new ShareSkills(_driver);
            obj.DeleteExsistingSkill();
        }

        [Test]
        public void checkmanagerequests()
        {
            //create extent report
            test = extent.StartTest("manage listings");

            //received requests
            ShareSkills obj = new ShareSkills(_driver);
            obj.RequestsReceived();
        }

        [Test]
        public void checksentrequests()
        {
            //create extent report
            test = extent.StartTest("manage listings");

            //sent requests
            ShareSkills obj = new ShareSkills(_driver);
            obj.RequestsSent();
        }

        [Test]
        public void allcategorysearchskill()
        {
            //create extent report
            test = extent.StartTest("all category skills");

            //sent requests
            SearchSkills obj = new SearchSkills(_driver);
            obj.AllCategorySearchSkills();
        }

        [Test]
        public void subcategorysearchskill()
        {
            //create extent report
            test = extent.StartTest("sub category skills");

            //sent requests
            SearchSkills obj = new SearchSkills(_driver);
            obj.SubCategorySearchSkills();
        }

        [Test]
        public void onlinefilter()
        {
            //create extent report
            test = extent.StartTest("sub category skills");

            //sent requests
            SearchSkills obj = new SearchSkills(_driver);
            obj.OnlineSearchSkill();
        }

        [Test]
        public void onsitefilter()
        {
            //create extent report
            test = extent.StartTest("sub category skills");

            //sent requests
            SearchSkills obj = new SearchSkills(_driver);
            obj.OnsiteSearchSkill();
        }

        [Test]
        public void showallfilter()
        {
            //create extent report
            test = extent.StartTest("sub category skills");

            //sent requests
            SearchSkills obj = new SearchSkills(_driver);
            obj.ShowAllSearchSkill();
        }

        [Test]
        public void chat()
        {
            //click on 'chat' linktext 
            Chat obj = new Chat(_driver);
            obj.ClickChat();
        }

    }
}


