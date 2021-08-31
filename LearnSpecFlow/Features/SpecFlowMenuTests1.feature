Feature: SpecFlowMenuTests1
	In order to easily find needed documentation 
	As a specflow user
	I want to be able to navigate to pages through main menu 

@smoke
Scenario Outline: Clicking menu option from the main menu should open corresponding page1
	Given I open official Specflow web site
	When I hover the '<menuItem>' menu item from the main menu
	And I click the '<subMenuItem>' option from sub menu
	Then Page with '<title>' title should be opened

	Examples:
		| menuItem | subMenuItem                         | title                                              |
		| Docs     | Step-By-Step Getting Started Guides | Welcome to the Step-By-Step Getting Started Guide! |
		| Docs     | Binding Tests                       | Bindings                                           |