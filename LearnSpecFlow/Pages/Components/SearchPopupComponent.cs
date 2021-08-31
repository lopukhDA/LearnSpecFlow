using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LearnSpecFlow.Pages.Components
{
	public class SearchPopupComponent : BasePage
	{
		public string InputXpath => "//input[@class='search__outer__input']";

		public string ResultPageXpath => "//div[@class='search__result__box']//div[@class='search__result__single']//a//h2//span";

		private static SearchPopupComponent _searchPopupComponent;

		public static SearchPopupComponent Instance => _searchPopupComponent ?? (_searchPopupComponent = new SearchPopupComponent());

		public void FillInput(string searchText)
		{
			var element = FindElement(By.XPath(InputXpath));
			element.SendKeys(searchText);
		}

		public void SelectItemByText(string text)
		{
			var element = FindElements(By.XPath(ResultPageXpath)).First(x => x.Text.Equals(text));
			element.Click();
		}
	}
}
