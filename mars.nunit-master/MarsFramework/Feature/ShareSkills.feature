Feature: ShareSkill and Manage Listings 
	Scenarios to add skill on share skill, edit and delete skill on manage listings on the MarsQA application.

@mytag
Scenario: Add skill to the Share Skill
	Given I clicked on share skill button on profile page
	When I enter the relevent details for skill
	And I click on save button to add skill
	Then I should be able to see the add success message for new share skill

Scenario: Edit skill in the Manage Listings 
	Given I clicked on manage listings button on profile page
	And I clicked on edit icon for an existing skill
	When I modify the relevant details for skill
	And I click on save button to add skill
	Then I should be able to see the update success message for exsisting skill

Scenario: Delete Skill in the Manage Listings
	Given I clicked on manage listings button on profile page
	And I clicked on delete icon for an existing skill
	Then I should be able to see the delete success message for deleted skill
