using MarsFramework.Global;
using MarsFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsFramework.HookUp
{
    [Binding]
    public class ShareSkillAndManageListingsSteps
    {
        [Given(@"I clicked on share skill button on profile page")]
        public void GivenIClickedOnShareSkillButtonOnProfilePage()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.newShareSkillButtonClick();
        }
        
        [Given(@"I clicked on manage listings button on profile page")]
        public void GivenIClickedOnManageListingsButtonOnProfilePage()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.navigateToManageListingsPage();
        }
        
        [Given(@"I clicked on edit icon for an existing skill")]
        public void GivenIClickedOnEditIconForAnExistingSkill()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.editShareSkill();
        }
        
        [Given(@"I clicked on delete icon for an existing skill")]
        public void GivenIClickedOnDeleteIconForAnExistingSkill()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.DeleteExsistingSkill();
        }
        
        [When(@"I enter the relevent details for skill")]
        public void WhenIEnterTheReleventDetailsForSkill()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.enterNewShareSkillDetails();
        }
        
        [When(@"I click on save button to add skill")]
        public void WhenIClickOnSaveButtonToAddSkill()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.saveNewShareSkill();
        }
        
        [When(@"I modify the relevant details for skill")]
        public void WhenIModifyTheRelevantDetailsForSkill()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.modifyShareSkillDetails();
        }
        
        [Then(@"I should be able to see the add success message for new share skill")]
        public void ThenIShouldBeAbleToSeeTheAddSuccessMessageForNewShareSkill()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.validateNewShareSkill();
        }
        
        [Then(@"I should be able to see the update success message for exsisting skill")]
        public void ThenIShouldBeAbleToSeeTheUpdateSuccessMessageForExsistingSkill()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.validateModifiedShareSkill();
        }
        
        [Then(@"I should be able to see the delete success message for deleted skill")]
        public void ThenIShouldBeAbleToSeeTheDeleteSuccessMessageForDeletedSkill()
        {
            ShareSkills objshareskills = new ShareSkills(Base._driver);
            objshareskills.validateDeleteShareSkill();
        }
    }
}
