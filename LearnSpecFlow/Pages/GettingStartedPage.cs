using OpenQA.Selenium;

namespace LearnSpecFlow.Pages
{
	public class GettingStartedPage : BasePage
	{
		private string TitleXpath => "//h1[text()='Welcome to the Step-By-Step Getting Started Guide!']";

		private static GettingStartedPage _gettingStartedPage;

		public static GettingStartedPage Instance => _gettingStartedPage ?? (_gettingStartedPage = new GettingStartedPage());

		public bool IsPageTitleDisplayed()
		{
			return IsDisplayed(By.XPath(TitleXpath));
		}
	}
}
