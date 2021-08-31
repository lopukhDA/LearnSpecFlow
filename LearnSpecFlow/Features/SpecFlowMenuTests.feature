Feature: SpecFlowMenuTests
	In order to easily find needed documentation 
	As a specflow user
	I want to be able to navigate to pages through main menu 

@smoke
Scenario: Clicking Getting Started option from the main menu should open Getting Started page
	Given I open official Specflow web site 
	When I hover the 'Docs' menu item from the main menu
	And I click the 'Step-By-Step Getting Started Guides' option from sub menu
	Then Page with 'Welcome to the Step-By-Step Getting Started Guide!' title should be opened