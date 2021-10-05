@Selenium
Feature: Profile
	Scenarios to Edit Availability, Edit Hours, Edit Earn Target, 
	Add Languages, Add Skills, Add Education, Add Certifications profile details of the Mars QA application

@mytag
Scenario: Edit Availability on the Profile Page
	Given I clicked on edit icon for the existing availability
	When I modify the relevant details for availability
	Then I should be able to see the availability updated sucess message on profile 
	
Scenario: Edit Hours on the Profile Page
	Given I clicked on edit icon for the existing Hours
	When I modify the relevant details for Hours
	Then I should be able to see the Hours updated sucess message on profile 

Scenario: Edit Earn Target on the Profile Page
	Given I clicked on edit icon for the existing earn target
	When I modify the relevant details for earn target
	Then I should be able to see the availability updated sucess message on profile
	
Scenario: Add Language to the Languages Tab
	Given I clicked on add new button under languages tab
	When I enter the relevant details for language
	And I click on add button to add language
	Then I should be able to see the add success message for new language 

Scenario: Add Skill to the Skills Tab
	Given I clicked on add new button under skills tab
	When I enter the relevant details for skill
	And I click on add button to add skills
	Then I should be able to see the add success message for new skill 

Scenario: Add Education to the Education Tab
	Given I clicked on add new button under education tab
	When I enter the relevant details for education
	And I click on add button to add education
	Then I should be able to see the add success message for new education

Scenario: Add Certification to the Certifications Tab
	Given I clicked on add new button under certifications tab
	When I enter the relevant details for certification
	And I click on add button to add certification
	Then I should be able to see the add success message for new certification

Scenario: Add Description on the Profile Page
	Given I clicked on edit icon to add text to description
	When I enter the relevant details for description
	And I click on save button to add description
	Then I should be able to see the add success message for description
	



