using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSpecFlow.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace LearnSpecFlow.Pages
{
	public class HomePage : BasePage
	{
		private string Url => "https://specflow.org";

		private string MainMenuItemXpath => "//ul[@id='menu-main-navigation']//li//a";

		private string SubMenuItemXpath => "//ul[@class='sub-menu']//li//a";

		private static HomePage _homePage;

		public static HomePage Instance => _homePage ?? (_homePage = new HomePage());

		public void OpenSpecFlowHomePage()
		{
			DriverManager.Instance().Navigate().GoToUrl(Url);
		}

		public void HoverMainMenuItem(string item)
		{
			var action = new Actions(DriverManager.Instance());
			var menuItem = FindElements(By.XPath(MainMenuItemXpath)).First(x => x.Text.Contains(item));
			action.MoveToElement(menuItem).Perform();
		}

		public void ClickSubMenuItem(string item)
		{
			var subMenuItem = FindElements(By.XPath(SubMenuItemXpath)).First(x => x.Text.Contains(item));
			subMenuItem.Click();
		}
	}
}
