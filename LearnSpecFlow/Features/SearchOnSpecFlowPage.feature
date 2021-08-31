Feature: SearchOnSpecFlowPage
	In order to easily find needed documentation with search
	As a specflow user
	I want to be able to search needed documentations through search popup on SpecFlow page 

@mytag
Scenario: Search Installation page through search popup
	Given I open official Specflow web site
	When I hover the 'Docs' menu item from the main menu
	And I click the 'SpecFlow' option from sub menu
	And I click the search docs field
	And I fill the 'Installation' on the search popup
	And I select "Installation" from the search results
	Then Page with 'Installation' title should be opened