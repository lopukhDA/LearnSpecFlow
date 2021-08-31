using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TechTalk.SpecFlow;

namespace LearnSpecFlow.Steps
{
	[Binding]
	public sealed class MainMenuSteps
	{
		// For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

		private readonly ScenarioContext _scenarioContext;

		public MainMenuSteps(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[Given(@"I open official Specflow web site")]
		public void OpenOfficialSpecflowWebSite()
		{
			ScenarioContext.Current.Pending();
		}

		[When(@"I hover the '(.*)' menu item from the main menu")]
		public void HoverTheMenuItemFromTheMainMenu(string menuItem)
		{
			ScenarioContext.Current.Pending();
		}

		[When(@"I click the '(.*)' option from sub menu")]
		public void ClickTheOptionFromSubMenu(string option)
		{
			ScenarioContext.Current.Pending();
		}

		[Then(@"Page with '(.*)' title should be opened")]
		public void PageWithTitleShouldBeOpened(string title)
		{
			ScenarioContext.Current.Pending();
		}

	}
}
