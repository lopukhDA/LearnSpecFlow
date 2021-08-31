﻿Feature: SpecFlowMenuTests
	In order to easily find needed documentation 
	As a specflow user
	I want to be able to navigate to pages through main menu 

@smoke
Scenario: Clicking Getting Started option from the main menu should open Getting Started page
	Given I open official Specflow web site 
	When I hover the 'Docs' menu item from the main menu
	And I click the 'Gettig Started' option from sub menu
	Then Page with 'Getting Started' title should be opened