using OpenQA.Selenium;

namespace LearnSpecFlow.Pages
{
	public class GettingStartedPage : BasePage
	{
		private static GettingStartedPage _gettingStartedPage;

		public static GettingStartedPage Instance => _gettingStartedPage ?? (_gettingStartedPage = new GettingStartedPage());
	}
}
