using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearnSpecFlow.Base;
using LearnSpecFlow.Pages;
using NUnit.Framework;
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
			HomePage.Instance.OpenSpecFlowHomePage();
		}

		[When(@"I hover the '(.*)' menu item from the main menu")]
		public void HoverTheMenuItemFromTheMainMenu(string menuItem)
		{
			HomePage.Instance.HoverMainMenuItem(menuItem);
		}

		[When(@"I click the '(.*)' option from sub menu")]
		public void ClickTheOptionFromSubMenu(string option)
		{
			HomePage.Instance.ClickSubMenuItem(option);
		}

		[Then(@"Page with '(.*)' title should be opened")]
		public void PageWithTitleShouldBeOpened(string title)
		{
			Assert.IsTrue(BasePage.Instance.IsPageTitleDisplayed(title), "Page title for the page is not displayed");
		}

		[AfterScenario]
		public static void AfterTestRun()
		{
			DriverManager.QuitDriver();
		}
	}
}
