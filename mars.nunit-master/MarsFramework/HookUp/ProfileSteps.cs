using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;
using MarsFramework.Global;
using MarsFramework.Pages;

namespace MarsFramework.HookUp
{

    [Binding]
    public class ProfileSteps
    {
        [Given(@"I clicked on edit icon for the existing availability")]
        public void GivenIClickedOnEditIconForTheExistingAvailability()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.editAvailabilityClickEditIcon();
        }
        
        [Given(@"I clicked on edit icon for the existing Hours")]
        public void GivenIClickedOnEditIconForTheExistingHours()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.editHoursClickEditIcon();
        }
        
        [Given(@"I clicked on edit icon for the existing earn target")]
        public void GivenIClickedOnEditIconForTheExistingEarnTarget()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.editEarnTargetClickEditIcon();
        }
        
        [Given(@"I clicked on add new button under languages tab")]
        public void GivenIClickedOnAddNewButtonUnderLanguagesTab()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addnewLanguageButtonClick();
        }
        
        [Given(@"I clicked on add new button under skills tab")]
        public void GivenIClickedOnAddNewButtonUnderSkillsTab()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addnewSkillButtonClick();
        }
        
        [Given(@"I clicked on add new button under education tab")]
        public void GivenIClickedOnAddNewButtonUnderEducationTab()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addnewEducationButtonClick();
        }
        
        [Given(@"I clicked on add new button under certifications tab")]
        public void GivenIClickedOnAddNewButtonUnderCertificationsTab()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addnewCertificationButtonClick();
        }
        
        [Given(@"I clicked on edit icon to add text to description")]
        public void GivenIClickedOnEditIconToAddTextToDescription()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.editDescription();
        }
        
        [When(@"I modify the relevant details for availability")]
        public void WhenIModifyTheRelevantDetailsForAvailability()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.modifyAvailability();
        }
        
        [When(@"I modify the relevant details for Hours")]
        public void WhenIModifyTheRelevantDetailsForHours()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.modifyHours();
        }
        
        [When(@"I modify the relevant details for earn target")]
        public void WhenIModifyTheRelevantDetailsForEarnTarget()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.modifyEarnTarget();
        }
        
        [When(@"I enter the relevant details for language")]
        public void WhenIEnterTheRelevantDetailsForLanguage()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addLanguageAndLevel();
        }
        
        [When(@"I click on add button to add language")]
        public void WhenIClickOnAddButtonToAddLanguage()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addLanguageClickAddButton();
        }
        
        [When(@"I enter the relevant details for skill")]
        public void WhenIEnterTheRelevantDetailsForSkill()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addSkillAndLevel();
        }
        
        [When(@"I click on add button to add skills")]
        public void WhenIClickOnAddButtonToAddSkills()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addSkillClickAddButton();
        }
        
        [When(@"I enter the relevant details for education")]
        public void WhenIEnterTheRelevantDetailsForEducation()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addEducationAndLevel();
        }
        
        [When(@"I click on add button to add education")]
        public void WhenIClickOnAddButtonToAddEducation()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addEducationClickAddButton();
        }
        
        [When(@"I enter the relevant details for certification")]
        public void WhenIEnterTheRelevantDetailsForCertification()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addCertificationDetails();
        }
        
        [When(@"I click on add button to add certification")]
        public void WhenIClickOnAddButtonToAddCertification()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addCertificationAddClickButton();
        }
        
        [When(@"I enter the relevant details for description")]
        public void WhenIEnterTheRelevantDetailsForDescription()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.enterTextToDescription();
        }
        
        [When(@"I click on save button to add description")]
        public void WhenIClickOnSaveButtonToAddDescription()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.addedDescriptionToSave();
        }
        
        [Then(@"I should be able to see the availability updated sucess message on profile")]
        public void ThenIShouldBeAbleToSeeTheAvailabilityUpdatedSucessMessageOnProfile()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.validateAvailability();
        }
        
        [Then(@"I should be able to see the Hours updated sucess message on profile")]
        public void ThenIShouldBeAbleToSeeTheHoursUpdatedSucessMessageOnProfile()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.validateHours();
        }
        
        [Then(@"I should be able to see the add success message for new language")]
        public void ThenIShouldBeAbleToSeeTheAddSuccessMessageForNewLanguage()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.validateLanguage();
        }
        
        [Then(@"I should be able to see the add success message for new skill")]
        public void ThenIShouldBeAbleToSeeTheAddSuccessMessageForNewSkill()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.validateSkill();
        }
        
        [Then(@"I should be able to see the add success message for new education")]
        public void ThenIShouldBeAbleToSeeTheAddSuccessMessageForNewEducation()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.validateEducation();
        }
        
        [Then(@"I should be able to see the add success message for new certification")]
        public void ThenIShouldBeAbleToSeeTheAddSuccessMessageForNewCertification()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.validateCertifications();
        }
        
        [Then(@"I should be able to see the add success message for description")]
        public void ThenIShouldBeAbleToSeeTheAddSuccessMessageForDescription()
        {
            Profile profileObj = new Profile(Base._driver);
            profileObj.validateDescription();
        }
    }
}
