using OpenQA.Selenium;

namespace LearnSpecFlow.Pages
{
	public class DocsPage : BasePage
	{
		private string SearchDocsXpath => "//div[@role='search']";

		private static DocsPage _docsPage;

		public static DocsPage Instance => _docsPage ?? (_docsPage = new DocsPage());

		public void ClickSearchDocs()
		{
			var element = FindElement(By.XPath(SearchDocsXpath));
			element.Click();
		}
	}
}
